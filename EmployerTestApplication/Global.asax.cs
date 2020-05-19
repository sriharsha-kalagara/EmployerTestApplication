using System;
using System.Web.Http;
using System.Web.Mvc;

namespace EmployerTestApplication
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
