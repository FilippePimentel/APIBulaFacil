using APIBulaFacil.Application.Mappings;
using APIBulaFacil.IoC;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace APIBulaFacil.Presentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Register();

            // Create the container as usual.
            var container = DependencyResolver.CreateContainer();
            // This is an extension method from the integration package.
            container.RegisterWebApiControllers
            (GlobalConfiguration.Configuration);

            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver =
            new SimpleInjectorWebApiDependencyResolver(container);
        }


    }
}
