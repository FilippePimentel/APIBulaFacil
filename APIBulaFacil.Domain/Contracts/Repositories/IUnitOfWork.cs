using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Contracts.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        IUsuarioRepository UsuarioRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        IFarmaciaRepository FarmaciaRepository { get; }
        IContraIndicacaoRepository ContraIndicacaoRepository { get; }
        IBulaFacilRepository BulaFacilRepository { get; }
        IIndicacaoRepository IndicacaoRepository { get; }
        IMedicamentoRepository MedicamentoRepository { get; }
        IModoDeUsoRepository ModoDeUsoRepository { get; }
        ISubstanciaRepository SubstanciaRepository { get; }
        IUnidadeMedidaRepository UnidadeMedidaRepository { get; }
        IMedicamentoFarmaciaRepository MedicamentoFarmaciaRepository { get; }
    }
}
