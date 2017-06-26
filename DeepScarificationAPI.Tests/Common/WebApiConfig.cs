using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace DeepScarificationAPI.Tests.Common
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            // 将 Web API 配置为仅使用不记名令牌身份验证。
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            // Web API 路由
            config.MapHttpAttributeRoutes();

          //  config.Routes.MapHttpRoute(
          //    name: "DefaultApi",
          //    routeTemplate: "api/{controller}/{action}/{code}",
          //    defaults: new { code = RouteParameter.Optional }
          //);
            config.Routes.MapHttpRoute(
             name: "DefaultApi",
             routeTemplate: "api/{controller}/{action}",
             defaults: new { code = RouteParameter.Optional }
         );
        }
    }
}
