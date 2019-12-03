using APIBulaFacil.Application.ViewModels.Usuarios;
using APIBulaFacil.Infra.Data.Repositories;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace APIBulaFacil.Presentation.App_Start
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            UsuarioRepository uRep = new UsuarioRepository(new Infra.Data.Context.DataContext());

            var usu = uRep.Find(context.UserName, context.Password);
            
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            //here you will write the DB code to validate user credentials
            if (usu == null)
            {
                context.SetError("invalid_grant", "O nome ou o usuário está incorreto.");
                return;
            }
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));
            identity.AddClaim(new Claim("time", DateTime.Now.ToString("ddMMyyyy hhmmssttffff")));
            
            context.Validated(identity);
        }
    }
}