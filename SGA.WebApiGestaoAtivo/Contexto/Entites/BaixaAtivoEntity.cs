using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Entites
{
    public class BaixaAtivoEntity
    {
        [BsonElement("data")]
        public DateTimeOffset Data { get; set; }

        [BsonElement("motivo")]
        public string Motivo { get; set; }

        [BsonElement("responsavel")]
        public string Responsavel { get; set; }

    }
}
