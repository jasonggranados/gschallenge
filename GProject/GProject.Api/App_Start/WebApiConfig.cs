using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using GProject.Api.IoC;
using GProject.Core.Mapping;
using GProject.Infrastructure.DataStore;

namespace GProject.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // IoC...
            config.DependencyResolver = Bootstraper.Bootstrap();
            
            // Domain vs Model vs ViewModel mapper configuration...
            AutomapperInitializer.Initialize();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );              
        }
    }
}
