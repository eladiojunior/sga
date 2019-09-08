using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using SGA.WebApiGestaoAtivo.Contexto.Entites;

namespace SGA.WebApiGestaoAtivo.Model
{
    public class SolicitacaoCompraAtivoModel
    {
        public string Id { get; set; }
        public string NumeroProtocolo { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string DescricaoSolicitacao { get; set; }
        public int CodigoSituacaoSolicitacao { get; set; }
        public string SituacaoSolicitacao { get; set; }
        public string Responsavel { get; set; }

        internal static ICollection<SolicitacaoCompraAtivoModel> ConverterToListModel(IEnumerable<SolicitacaoCompraAtivoEntity> entites)
        {
            List<SolicitacaoCompraAtivoModel> listModels = new List<SolicitacaoCompraAtivoModel>();
            if (entites == null)
                return listModels;
            foreach (var item in entites)
            {
                listModels.Add(ConverterToModel(item));
            }
            return listModels;
        }

        internal static SolicitacaoCompraAtivoEntity ConverterToEntity(SolicitacaoCompraAtivoModel model)
        {
            if (model == null)
                return null;
            SolicitacaoCompraAtivoEntity entity = new SolicitacaoCompraAtivoEntity();
            if (!string.IsNullOrEmpty(model.Id))
                entity.Id = ObjectId.Parse(model.Id);
            entity.NumeroProtocolo = model.NumeroProtocolo;
            entity.DataSolicitacao = model.DataSolicitacao;
            entity.DescricaoSolicitacao = model.DescricaoSolicitacao;
            entity.DescricaoSituacao = model.SituacaoSolicitacao;
            entity.CodigoSituacao = model.CodigoSituacaoSolicitacao;
            entity.Responsavel = model.Responsavel;
            return entity;
        }

        internal static SolicitacaoCompraAtivoModel ConverterToModel(SolicitacaoCompraAtivoEntity entity)
        {
            if (entity == null)
                return null;
            SolicitacaoCompraAtivoModel model = new SolicitacaoCompraAtivoModel();
            model.Id = entity.Id.ToString();
            model.NumeroProtocolo = entity.NumeroProtocolo;
            model.DataSolicitacao = entity.DataSolicitacao.DateTime;
            model.DescricaoSolicitacao = entity.DescricaoSolicitacao;
            model.SituacaoSolicitacao = entity.DescricaoSituacao;
            model.CodigoSituacaoSolicitacao = entity.CodigoSituacao;
            model.Responsavel = entity.Responsavel;
            return model;
        }
    }
}
