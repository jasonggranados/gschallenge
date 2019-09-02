using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using GProject.Api.IoC;
using GProject.Core.Mapping;
using GProject.Infrastructure.DataStore;
using Newtonsoft.Json.Serialization;

namespace GProject.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // IoC...
            config.DependencyResolver = Bootstraper.Bootstrap();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

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
