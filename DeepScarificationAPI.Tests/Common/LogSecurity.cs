using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using DeepScarificationAPI.Tests.Model;

namespace DeepScarificationAPI.Tests.Common
{
    public class LogSecurity
    {

        public static string GetMD5(string sDataIn)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var bytValue = Encoding.UTF8.GetBytes(sDataIn);
            var bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            var sTemp = bytHash.Aggregate("", (current, t) => current + t.ToString("X").PadLeft(2, '0'));
            return sTemp.ToLower();
        }

        public static string TrimSpecialSymbol(string oldStr)
        {
            char[] TrimChar = { '<', '>', '-', '\'', '\"', '\\' };
            return oldStr.Trim(TrimChar);
        }

        /// <summary>
        /// 获取用户请求数据
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public static LogInterfaceResultModel GetRequestModel(HttpRequestMessage req)
        {
            try
            {
                var tpUserNamePwd = ExtractUserNameAndPassword(req.Headers.Authorization.Parameter);
                var modelStr = TrimSpecialSymbol(req.Content.ReadAsStringAsync().Result);
                modelStr = DESEncrypt.Decrypt(modelStr, tpUserNamePwd.Item2);
                var model = JsonConvert.DeserializeObject<LogInterfaceResultModel>(modelStr);
                return model;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Tuple<string, string> ExtractUserNameAndPassword(string authorizationParameter)
        {
            byte[] credentialBytes;

            try
            {
                credentialBytes = Convert.FromBase64String(authorizationParameter);
            }
            catch (FormatException)
            {
                return null;
            }

            var encoding = Encoding.ASCII;
            encoding = (Encoding)encoding.Clone();
            encoding.DecoderFallback = DecoderFallback.ExceptionFallback;
            string decodedCredentials;

            try
            {
                decodedCredentials = encoding.GetString(credentialBytes);
            }
            catch (DecoderFallbackException)
            {
                return null;
            }

            if (String.IsNullOrEmpty(decodedCredentials))
            {
                return null;
            }

            var colonIndex = decodedCredentials.IndexOf(':');
            if (colonIndex == -1)
            {
                return null;
            }

            var userName = decodedCredentials.Substring(0, colonIndex);
            var password = decodedCredentials.Substring(colonIndex + 1);
            return new Tuple<string, string>(userName, password);
        }
    }
}