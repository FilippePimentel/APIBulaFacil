using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Entities;
using APIBulaFacil.Infra.Data.Context;
using APIBulaFacil.Infra.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Repositories
{
    public class BulaFacilRepository : BaseRepository<BulaFacil, Int32>, IBulaFacilRepository
    {
        private readonly DataContext context;

        public BulaFacilRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public override void Add(BulaFacil bulaFacil)
        {
            context.Entry(bulaFacil).State = EntityState.Added;

            foreach (var tag in bulaFacil.Posologias)
            {
                context.Entry(tag).State = EntityState.Unchanged;
            }
            //foreach (var tag in bulaFacil.Indicacoes)
            //{
            //    context.Entry(tag).State = EntityState.Unchanged;
            //}
            //foreach (var tag in bulaFacil.ContraIndicacoes)
            //{
            //    context.Entry(tag).State = EntityState.Unchanged;
            //}

            context.Entry(bulaFacil.Medicamento).State = EntityState.Unchanged;

            context.BulaFacil.Add(bulaFacil);
            context.SaveChanges();
        }
        public override void Modify(BulaFacil obj)
        {
            var ObjetoDoBanco = base.GetById(obj.IdBulaFacil);

            //List<ContraIndicacao> ContraIndicacoesSalvas = new List<ContraIndicacao>();
            //List<Indicacao> IndicacoesSalvas = new List<Indicacao>();
            List<Posologia> PosologiasSalvas = new List<Posologia>();

            ObjetoDoBanco.Link = obj.Link;
            ObjetoDoBanco.Substancia = obj.Substancia;
            ObjetoDoBanco.Valido = obj.Valido;
            ObjetoDoBanco.ContraIndicacao = obj.ContraIndicacao;
            ObjetoDoBanco.Indicacao = obj.Indicacao;
            ObjetoDoBanco.Medicamento = new Medicamento() { IdMedicamento = obj.Medicamento.IdMedicamento };
            
            List<Posologia> posologiasDeletadas = new List<Posologia>();

            foreach (var posologiaNoBanco in ObjetoDoBanco.Posologias)
            {
                if (!obj.Posologias.Any(e => e.IdPosologia == posologiaNoBanco.IdPosologia))
                {
                    posologiasDeletadas.Add(posologiaNoBanco);
                }
            }

            posologiasDeletadas.ForEach(c => { ObjetoDoBanco.Posologias.Remove(c); });

            ObjetoDoBanco.Posologias.ToList().ForEach(posologia =>
            {
                var posologiaVO = obj.Posologias.Where(c => c.IdPosologia == posologia.IdPosologia).FirstOrDefault();
                PosologiasSalvas.Add(posologiaVO);
                obj.Posologias.Remove(posologiaVO);
            }
            );

            var novasPosologias = obj.Posologias.Select(posologiaVO =>
            {
                var posologia = new Posologia()
                {
                    IdPosologia = posologiaVO.IdPosologia
                };
                return posologia;
            }).ToList();

            foreach (var item in novasPosologias)
            {
                ObjetoDoBanco.Posologias.Add(item);
            }

            //List<ContraIndicacao> contraIndicacoesDeletadas = new List<ContraIndicacao>();

            //foreach (var contraIndicacaoNoBanco in ObjetoDoBanco.ContraIndicacoes)
            //{
            //    if (!obj.ContraIndicacoes.Any(e => e.IdContraIndicacao == contraIndicacaoNoBanco.IdContraIndicacao))
            //    {
            //        contraIndicacoesDeletadas.Add(contraIndicacaoNoBanco);
            //    }
            //}
            //contraIndicacoesDeletadas.ForEach(c => { ObjetoDoBanco.ContraIndicacoes.Remove(c); });

            //ObjetoDoBanco.ContraIndicacoes.ToList().ForEach(ContraIndicacao =>
            //{
            //    var ContraIndicacaoVO = obj.ContraIndicacoes.Where(c => c.IdContraIndicacao == ContraIndicacao.IdContraIndicacao).FirstOrDefault();
            //    obj.ContraIndicacoes.Remove(ContraIndicacaoVO);
            //    ContraIndicacoesSalvas.Add(ContraIndicacaoVO);
            //}
            //);

            //var novasContraIndicacoes = obj.ContraIndicacoes.Select(ContraIndicacaoVO =>
            //{
            //    var ContraIndicacao = new ContraIndicacao()
            //    {
            //        IdContraIndicacao = ContraIndicacaoVO.IdContraIndicacao
            //    };
            //    return ContraIndicacao;
            //}).ToList();

            //foreach (var item in novasContraIndicacoes)
            //{
            //    ObjetoDoBanco.ContraIndicacoes.Add(item);
            //}

            //List<Indicacao> indicacoesDeletadas = new List<Indicacao>();

            //foreach (var indicacaoNoBanco in ObjetoDoBanco.Indicacoes)
            //{
            //    if (!obj.Indicacoes.Any(e => e.IdIndicacao == indicacaoNoBanco.IdIndicacao))
            //    {
            //        indicacoesDeletadas.Add(indicacaoNoBanco);
            //    }
            //}

            //indicacoesDeletadas.ForEach(c => { ObjetoDoBanco.Indicacoes.Remove(c); });

            //ObjetoDoBanco.Indicacoes.ToList().ForEach(indicacao =>
            //{
            //    var indicacaoVO = obj.Indicacoes.Where(c => c.IdIndicacao == indicacao.IdIndicacao).FirstOrDefault();
            //    obj.Indicacoes.Remove(indicacaoVO);
            //    IndicacoesSalvas.Add(indicacaoVO);
            //}
            //);

            //var novasIndicacoes = obj.Indicacoes.Select(indicacaoVO =>
            //{
            //    var indicacao = new Indicacao()
            //    {
            //        IdIndicacao = indicacaoVO.IdIndicacao
            //    };
            //    return indicacao;
            //}).ToList();

            //foreach (var item in novasIndicacoes)
            //{
            //    ObjetoDoBanco.Indicacoes.Add(item);
            //}

            ObjetoDoBanco.Posologias.Except(obj.Posologias.Select(vo => new Posologia()
            {
                IdPosologia = vo.IdPosologia
            })).ToList();

            foreach (var tag in ObjetoDoBanco.Posologias)
            {
                    context.Entry(tag).State = EntityState.Unchanged;
            }
            //foreach (var tag in ObjetoDoBanco.Indicacoes)
            //{
            //    context.Entry(tag).State = EntityState.Unchanged;
            //}
            //foreach (var tag in ObjetoDoBanco.ContraIndicacoes)
            //{
            //    context.Entry(tag).State = EntityState.Unchanged;
            //}

            context.Entry(ObjetoDoBanco.Medicamento).State = EntityState.Unchanged;

            context.Entry(ObjetoDoBanco).State = EntityState.Modified;
            context.SaveChanges();
        }


    }
}
