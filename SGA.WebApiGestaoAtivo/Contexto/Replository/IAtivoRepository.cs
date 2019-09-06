using MongoDB.Bson;
using SGA.WebApiGestaoAtivo.Contexto.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Replository
{
    public interface IAtivoRepository
    {
        Task<IEnumerable<AtivoEntity>> GetAllAtivosAsync();
        Task<AtivoEntity> GetAtivo(string id);
        Task Create(AtivoEntity ativo);
        Task<bool> Update(AtivoEntity ativo);
        Task<bool> Delete(string id);
    }
}
