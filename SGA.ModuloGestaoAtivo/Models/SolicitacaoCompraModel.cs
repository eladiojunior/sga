using SGA.ModuloGestaoAtivo.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class SolicitacaoCompraModel
    {
        public string Id { get; set; }
        public string NumeroProtocolo { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string DescricaoSolicitacao { get; set; }
        public int CodigoSituacaoSolicitacao { get; set; }
        public string SituacaoSolicitacao { get; set; }

        internal static SolicitacaoCompraModel ConvertToModel(SolicitacaoCompraModelApi modelApi)
        {
            SolicitacaoCompraModel model = new SolicitacaoCompraModel();
            model.Id = modelApi.Id;
            model.NumeroProtocolo = modelApi.NumeroProtocolo;
            model.DataSolicitacao = modelApi.DataSolicitacao;
            model.DescricaoSolicitacao = modelApi.DescricaoSolicitacao;
            model.CodigoSituacaoSolicitacao = modelApi.CodigoSituacaoSolicitacao;
            model.SituacaoSolicitacao = modelApi.SituacaoSolicitacao;
            return model;
        }
    }
}
