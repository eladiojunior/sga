using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Entites
{
    public class ManutencaoAtivoEntity
    {
        [BsonElement("data")]
        public DateTimeOffset Data { get; set; }

        [BsonElement("hasPreventiva")]
        public bool HasPreventiva { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("responsavel")]
        public string Responsavel { get; set; }

    }
}
