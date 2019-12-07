﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.UnidadesMedida
{
    public class UnidadeMedidaCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Tipo { get; set; }
    }
}
