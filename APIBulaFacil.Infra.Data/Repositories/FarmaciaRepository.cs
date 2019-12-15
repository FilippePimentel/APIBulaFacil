using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Entities;
using APIBulaFacil.Infra.Data.Context;
using System;
using System.Data.Entity;

namespace APIBulaFacil.Infra.Data.Repositories
{
    public class FarmaciaRepository : BaseRepository<Farmacia, Int32>, IFarmaciaRepository
    {
        private readonly DataContext context;

        public FarmaciaRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public override void Remove(Farmacia farmacia)
        {
            if (farmacia.Endereco != null)
            {
                context.Entry(farmacia.Endereco).State = EntityState.Deleted;
            }
            context.Entry(farmacia).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public override void Modify(Farmacia farmacia)
        {
            var ObjetoDoBanco = base.GetById(farmacia.IdUsuario);
            if (ObjetoDoBanco != null) {
                ObjetoDoBanco.Nome = farmacia.Nome;
                ObjetoDoBanco.RazaoSocial = farmacia.RazaoSocial;
                ObjetoDoBanco.Telefone = farmacia.Telefone;
                ObjetoDoBanco.Site = farmacia.Site;
                ObjetoDoBanco.Email = farmacia.Email;
                ObjetoDoBanco.Cnpj = farmacia.Cnpj;
                context.Entry(ObjetoDoBanco).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}