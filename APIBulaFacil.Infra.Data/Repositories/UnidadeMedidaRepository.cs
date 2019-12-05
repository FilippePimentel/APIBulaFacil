﻿using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Entities;
using APIBulaFacil.Infra.Data.Context;
using APIBulaFacil.Infra.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Repositories
{
    public class UnidadeMedidaRepository : BaseRepository<UnidadeMedida, Int32>, IUnidadeMedidaRepository
    {
        private readonly DataContext context;

        public UnidadeMedidaRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

    }
}