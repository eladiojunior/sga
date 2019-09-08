using MongoDB.Bson;
using MongoDB.Driver;
using SGA.WebApiGestaoAtivo.Contexto.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Replository
{
    public class SolicitacaoCompraAtivoRepository : ISolicitacaoCompraAtivoRepository
    {
        private readonly IApplicationDbContext _context;
        public SolicitacaoCompraAtivoRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(SolicitacaoCompraAtivoEntity solicitacao)
        {
            await _context.SolicitacoesCompraAtivo.InsertOneAsync(solicitacao);
        }

        public async Task<bool> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;
            ObjectId objectId = new ObjectId(id);
            FilterDefinition<SolicitacaoCompraAtivoEntity> filter = Builders<SolicitacaoCompraAtivoEntity>.Filter.Eq(m => m.Id, objectId);
            DeleteResult deleteResult = await _context.SolicitacoesCompraAtivo.DeleteOneAsync(filter);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public Task<SolicitacaoCompraAtivoEntity> Get(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;
            ObjectId objectId = new ObjectId(id);
            FilterDefinition<SolicitacaoCompraAtivoEntity> filter = Builders<SolicitacaoCompraAtivoEntity>.Filter.Eq(m => m.Id, objectId);
            return _context.SolicitacoesCompraAtivo.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<SolicitacaoCompraAtivoEntity>> GetAllAsync()
        {
            return await _context.SolicitacoesCompraAtivo.Find(_ => true).ToListAsync();
        }

        public async Task<bool> Update(SolicitacaoCompraAtivoEntity solicitacao)
        {
            if (solicitacao == null || solicitacao.Id == null)
                return false;
            ReplaceOneResult updateResult = await _context.SolicitacoesCompraAtivo.ReplaceOneAsync(filter: g => g.Id == solicitacao.Id, replacement: solicitacao);
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }
    }
}
