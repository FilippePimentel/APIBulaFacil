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
    }
}