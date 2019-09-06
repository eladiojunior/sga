using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using NUnit.Framework;
using System;

namespace Tests
{
    public class UnitTest_ConnectMongo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConnectionMongoDB()
        {

            IMongoDatabase _db;
            var client = new MongoClient("mongodb://localhost:17017");
            _db = client.GetDatabase("sgaDb");

            var collection = _db.GetCollection<AtivoEntity>("Ativos");
            
            //Incluir
            AtivoEntity ativo = new AtivoEntity();
            ativo.Nome = "Teste";
            ativo.DataRegistro = DateTime.Now;

            collection.InsertOneAsync(ativo);

            var list = collection.Find(_ => true).ToListAsync().Result;
            if (list.Count == 0)
                Assert.Fail("Não registrado.");

        }
    }

    public class AtivoEntity
    {
        public ObjectId Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("dataRegistro")]
        public DateTimeOffset DataRegistro { get; set; }

    }
}