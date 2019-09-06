using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Entites
{
    public class AtivoEntity
    {
        public ObjectId Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("dataRegistro")]
        public DateTimeOffset DataRegistro { get; set; }

    }
}
