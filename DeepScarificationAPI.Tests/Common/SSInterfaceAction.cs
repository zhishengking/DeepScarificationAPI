using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using DeepScarificationAPI.Tests.Common;
using DeepScarificationAPI.Tests.Model;

namespace DeepScarificationAPI.Tests.Common
{
    public class SSInterfaceAction
    {
        private static readonly MemoryCache MCache = new MemoryCache("CachingProvider");
        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="model">参数Model</param>
        /// <param name="userName">企联网开放api用户名</param>
        /// <param name="userPwd">企联网开放api密码</param>
        /// <param name="cacheDay">默认缓存天数</param>
        /// <returns></returns>
        public SSInterfaceResultModel Send(SSInterfaceResultModel model, string userName, string userPwd, int cacheDay = 7)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
            {
                model.ResponseCode = 10001;
                model.ExceptionMessage = "用户名或者密码不能为空！";
                return model;
            }

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", SSSecurity.GetBase64(userName + ":" + userPwd));
            var result = new HttpResponseMessage();
            try
            {
                switch (model.SendMethod.ToLower())
                {
                    case "get":
                        result = client.GetAsync(model.ServiceURL).Result;
                        break;
                    case "post":
                        var jsonPatam = JsonConvert.SerializeObject(model);
                        var encryptedModelStr = DESEncrypt.Encrypt(jsonPatam, userPwd);
                        result = client.PostAsync(model.ServiceURL, encryptedModelStr, new JsonMediaTypeFormatter()).Result;
                        break;
                }
                model.ResponseCode = (int)result.StatusCode;
                model.ExceptionMessage = result.ReasonPhrase;
                model.Result = result.Content.ReadAsStringAsync().Result;
                SaveCache(userName + userPwd + model.ServiceURL + JsonConvert.SerializeObject(model.ParameterModel), model.Result, cacheDay);
            }
            catch (Exception ex)
            {
                model.ResponseCode = 503;
                model.ExceptionMessage = ex.ToString();
                var cacheResult = GetCache(userName + userPwd + model.ServiceURL + JsonConvert.SerializeObject(model.ParameterModel));
                if (cacheResult == null) return model;
                model.ResponseCode = 200;
                model.ExceptionMessage = string.Empty;
                model.Result = cacheResult;
            }
            return model;
        }

        private static void SaveCache(string key, string value, int cacheDay)
        {
            var md5Key = SSSecurity.GetMD5(key);
            var cacheResult = MCache[md5Key];
            if (cacheResult != null)
                MCache.Remove(md5Key);
            MCache.Add(md5Key, value, DateTime.Now.AddDays(cacheDay));
        }

        private static string GetCache(string key)
        {
            var md5Key = SSSecurity.GetMD5(key);
            var cacheResult = MCache[md5Key];
            return cacheResult != null ? cacheResult.ToString() : null;
        }
    }
}
