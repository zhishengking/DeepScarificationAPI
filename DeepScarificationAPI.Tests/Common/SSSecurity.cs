using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace DeepScarificationAPI.Tests.Common
{
    public static class SSSecurity
    {
        private const string SSTokenCacheStr = "QlwCachingKey";
        private static readonly MemoryCache _Cache = new MemoryCache("CachingProvider");
        private static readonly object Padlock = new object();
        public static string GetTokenKey()
        {
            lock (Padlock)
            {
                var res = _Cache[SSTokenCacheStr];
                if (res != null)
                    return res.ToString();
                const string infoKeys = "Win32_Processor,Win32_BIOS,Win32_DiskDrive,Win32_PhysicalMemory";
                var allSysInfo = infoKeys.Split(',').Aggregate(string.Empty, (current, infoKey) => current + InsertInfo(infoKey));
                var result = GetMD5(allSysInfo);
                _Cache.Add(SSTokenCacheStr, result, DateTimeOffset.Now.AddDays(1));
                return result;
            }
        }

        private static string InsertInfo(string key)
        {
            var searcher = new ManagementObjectSearcher("select * from " + key);
            var sb = new StringBuilder();
            try
            {
                foreach (ManagementObject share in searcher.Get())
                {
                    try
                    {
                        sb.Append("Name:" + share["Name"]);
                    }
                    catch
                    {
                        sb.Append(share);
                    }

                    if (share.Properties.Count <= 0)
                    {
                        return string.Empty;
                    }

                    foreach (var pc in from PropertyData pc in share.Properties where pc.Name != "LoadPercentage" where pc.Value != null && pc.Value.ToString() != "" select pc)
                    {
                        switch (pc.Value.GetType().ToString())
                        {
                            case "System.String[]":
                                var str = (string[])pc.Value;
                                var str2 = str.Aggregate("", (current, st) => current + (st + " "));
                                sb.Append(pc.Name + str2);
                                break;
                            case "System.UInt16[]":
                                var shortData = (ushort[])pc.Value;
                                var tstr2 = shortData.Aggregate("", (current, st) => current + (st.ToString() + " "));
                                sb.Append(pc.Name + tstr2);
                                break;
                            default:
                                sb.Append(pc.Name + pc.Value);
                                break;
                        }
                    }
                }
            }
            catch (Exception exp)
            {

            }

            return sb.ToString();
        }

        public static string GetMD5(string key)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var bytValue = Encoding.UTF8.GetBytes(key);
            var bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            var sTemp = bytHash.Aggregate("", (current, t) => current + t.ToString("X").PadLeft(2, '0'));
            return sTemp.ToLower();
        }

        public static string GetBase64(string key)
        {
            var encoding = Encoding.ASCII;
            return Convert.ToBase64String(encoding.GetBytes(key));
        }

    }
}
