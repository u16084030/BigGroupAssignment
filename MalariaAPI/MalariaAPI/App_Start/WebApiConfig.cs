using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MalariaAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
<<<<<<< HEAD
            var cors = new EnableCorsAttribute("*", "*", "*");
=======
            var cors = new EnableCorsAttribute("*", "*", "*");//origins,headers,methods   
>>>>>>> 6c80a15f92b25044e106e0c2c985abaa9c534caa
            config.EnableCors(cors);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
