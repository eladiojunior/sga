using MongoDB.Bson;
using SGA.WebApiGestaoAtivo.Contexto.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Replository
{
    public interface ISolicitacaoCompraAtivoRepository
    {
        Task<IEnumerable<SolicitacaoCompraAtivoEntity>> GetAllAsync();
        Task<SolicitacaoCompraAtivoEntity> Get(string id);
        Task Create(SolicitacaoCompraAtivoEntity solicitacao);
        Task<bool> Update(SolicitacaoCompraAtivoEntity solicitacao);
        Task<bool> Delete(string id);
    }
}
