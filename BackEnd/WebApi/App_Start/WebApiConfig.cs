using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using WebApi.App_Start;
using WebApi.DAC.DataAccess;
using WebApi.Domain.Interfaces.DAC;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API configuration and services
            var container = new UnityContainer();           
            container.RegisterType(typeof(IRepository<>), typeof(BaseRepository<>));
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            config.DependencyResolver = new UnityResolver(container);

            // Configuración y servicios de API web
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

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
