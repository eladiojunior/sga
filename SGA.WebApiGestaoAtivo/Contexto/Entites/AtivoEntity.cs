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

        [BsonElement("tipo")]
        public string Tipo { get; set; }

        [BsonElement("qtdDiasManutencao")]
        public int QtdDiasManutencao { get; set; }

        [BsonElement("dataUltimaManutencao")]
        public DateTimeOffset? DataUltimaManutencao { get; set; }

        [BsonElement("dataRegistro")]
        public DateTimeOffset DataRegistro { get; set; }

        [BsonElement("manutencoes")]
        public ICollection<ManutencaoAtivoEntity> Manutencoes { get; set; }

        [BsonElement("baixa")]
        public BaixaAtivoEntity Baixa { get; set; }

        [BsonElement("responsavel")]
        public string Responsavel { get; set; }

    }
}
