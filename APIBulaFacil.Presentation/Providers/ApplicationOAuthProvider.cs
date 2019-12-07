using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Newtonsoft.Json;
using APIBulaFacil.Application.Services;
using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Usuarios;

namespace APIBulaFacil.Presentation.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        //sobrescrever..
        private readonly IUsuarioApplicationService applicationService;

        public ApplicationOAuthProvider(IUsuarioApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        public override Task ValidateClientAuthentication
        (OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.FromResult<object>(null);
        }

        //método para gerar a autenticação do usuario..
        //sobrescrever..
        public override Task GrantResourceOwnerCredentials
        (OAuthGrantResourceOwnerCredentialsContext context)
        {
            //verificar se o usuario existe na base de dados..
            UsuarioConsultaViewModel cons = applicationService.ObterParaValidar(context.UserName, context.Password);

            if (cons != null)
            {
                //criando uma autorização de acesso..
                Claim c = new Claim(ClaimTypes.Name, JsonConvert.SerializeObject(cons));

                //gravando a autorização de acesso..
                Claim[] autorizacoes = new Claim[] { c };
                ClaimsIdentity id = new ClaimsIdentity(autorizacoes,
                OAuthDefaults.AuthenticationType);
                context.Validated(id); //usuario esta autenticado!
            }
            return Task.FromResult<object>(null);

        }
    }
}
