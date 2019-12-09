using System.Web.Http;
using WebActivatorEx;
using APIBulaFacil.Presentation;
using Swashbuckle.Application;
using APIBulaFacil.Presentation.App_Start;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace APIBulaFacil.Presentation
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                           .EnableSwagger(c =>
                           {
                               //c.DocumentFilter<AuthTokenOperation>();
                               //c.OperationFilter<AuthorizationHeaderParameterOperationFilter>(); 
                               c.SingleApiVersion("v1", "Bula F�cil API - TCC UNIGRANRIO 2019")
                               .Description("Projeto TCC - Filippe, Juliana, Ruan");
})
                .EnableSwaggerUi(c =>
                    {
                        });
        }
    }
}
