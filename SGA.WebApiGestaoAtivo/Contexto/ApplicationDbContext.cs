using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SGA.WebApiGestaoAtivo.Contexto.Entites;

namespace SGA.WebApiGestaoAtivo.Contexto
{
    public class ApplicationDbContext : IApplicationDbContext
    {
        private readonly IMongoDatabase _db;
        public ApplicationDbContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<AtivoEntity> Ativos => _db.GetCollection<AtivoEntity>("Ativos");
        public IMongoCollection<SolicitacaoCompraAtivoEntity> SolicitacoesCompraAtivo => _db.GetCollection<SolicitacaoCompraAtivoEntity>("SolicitacoesCompraAtivo");
    }

    public interface IApplicationDbContext
    {
        IMongoCollection<AtivoEntity> Ativos { get; }
        IMongoCollection<SolicitacaoCompraAtivoEntity> SolicitacoesCompraAtivo { get; }
    }
}
