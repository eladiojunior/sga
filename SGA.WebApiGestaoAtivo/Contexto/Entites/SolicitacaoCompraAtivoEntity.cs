using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.WebApiGestaoAtivo.Contexto.Entites
{
    public class SolicitacaoCompraAtivoEntity
    {
        public ObjectId Id { get; set; }

        [BsonElement("numeroProtocolo")]
        public string NumeroProtocolo { get; set; }

        [BsonElement("dataSolicitacao")]
        public DateTimeOffset DataSolicitacao { get; set; }

        [BsonElement("descricaoSolicitacao")]
        public string DescricaoSolicitacao { get; set; }

        [BsonElement("codigoSituaca")]
        public int CodigoSituacao { get; set; }

        [BsonElement("descricaoSituacao")]
        public string DescricaoSituacao { get; set; }

        [BsonElement("responsavel")]
        public string Responsavel { get; set; }
    }
}
