using MongoDB.Bson;
using MongoDB.Driver;
using SGA.WebApiGestaoAtivo.Contexto.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Replository
{
    public class AtivoRepository : IAtivoRepository
    {
        private readonly IApplicationDbContext _context;
        public AtivoRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(AtivoEntity ativo)
        {
            ativo.DataRegistro = DateTime.Now;
            await _context.Ativos.InsertOneAsync(ativo);
        }

        public async Task<bool> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;
            ObjectId objectId = new ObjectId(id);
            FilterDefinition<AtivoEntity> filter = Builders<AtivoEntity>.Filter.Eq(m => m.Id, objectId);
            DeleteResult deleteResult = await _context.Ativos.DeleteOneAsync(filter);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<AtivoEntity>> GetAllAtivosAsync()
        {
            return await _context.Ativos.Find(_ => true).ToListAsync();
        }

        public Task<AtivoEntity> GetAtivo(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;
            ObjectId objectId = new ObjectId(id);
            FilterDefinition<AtivoEntity> filter = Builders<AtivoEntity>.Filter.Eq(m => m.Id, objectId);
            return _context.Ativos.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<bool> Update(AtivoEntity ativo)
        {
            if (ativo == null || ativo.Id == null)
                return false;
            ReplaceOneResult updateResult = await _context.Ativos.ReplaceOneAsync(filter: g => g.Id == ativo.Id, replacement: ativo);
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }
    }
}
