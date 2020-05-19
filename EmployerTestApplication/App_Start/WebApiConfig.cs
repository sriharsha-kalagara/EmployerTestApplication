using EmployerTestApplication.App_Start;
using System;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace EmployerTestApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.Clear();
            config.Formatters.Add(new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            config.Formatters.Add(new System.Net.Http.Formatting.XmlMediaTypeFormatter());

            config.MessageHandlers.Add(new RequestInspector());
            config.Services.Replace(typeof(IExceptionHandler), new EmployerplaceExceptionHandler());
            config.Services.Replace(typeof(IExceptionLogger), new RequestLogger());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
