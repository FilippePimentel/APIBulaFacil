﻿using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Enderecos;
using APIBulaFacil.Infra.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIBulaFacil.Presentation.Controllers
{
    [RoutePrefix("api/Endereco")]
    public class EnderecoController : ApiController
    {
        //atributo
        private readonly IEnderecoApplicationService applicationService;
        private MensagemError mensagensErro { get; set; }

        public EnderecoController(IEnderecoApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpPost]
        public HttpResponseMessage Post(EnderecoCadastroViewModel model)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest, MensagemError.GetErrorListFromModelState(ModelState));

            try
            {
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
        public HttpResponseMessage Put(EnderecoEdicaoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            try
            {
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