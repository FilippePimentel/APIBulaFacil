using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.UsuarioMobile;
using APIBulaFacil.Application.ViewModels.Usuarios;
using APIBulaFacil.Infra.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBulaFacil.Presentation.Controllers
{
    [RoutePrefix("api/UsuarioMobile")]
    public class UsuarioMobileController : ApiController
    {
        //atributo
        private readonly IUsuarioMobileApplicationService applicationService;
        private MensagemError MensagensErro { get; set; }

        public UsuarioMobileController(IUsuarioMobileApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpPost]
        public HttpResponseMessage Post(UsuarioMobileCadastroViewModel model)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest, MensagemError.GetErrorListFromModelState(ModelState));

            try
            {
                model.Senha = Criptografia.EncryptMD5(model.Senha);
                applicationService.Incluir(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse
                    (HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(UsuarioMobileEdicaoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            try
            {
                model.Senha = Criptografia.EncryptMD5(model.Senha);
                applicationService.Alterar(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse
                    (HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                applicationService.Remover(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse
                    (HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var model = applicationService.ObterTodos();
                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse
                    (HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var model = applicationService.ObterPorId(id);
                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse
                    (HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
