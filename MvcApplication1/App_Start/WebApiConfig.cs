using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MvcApplication1
{
    public static class WebApiConfig
    {
        [EnableCors(origins: "http://spaceaidproject.eu", headers: "*", methods: "*")]
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
