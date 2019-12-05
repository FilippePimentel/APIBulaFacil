﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace APIBulaFacil.Application.Mappings
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg
                =>
            {
                cfg.AddProfile<ViewModelToEntityMap>();
                cfg.AddProfile<EntityToViewModelMap>();
            });
        }
    }

}