using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Service.Model
{
    public class SolicitacaoCompraModelApi
    {
        public string Id { get; set; }
        public string NumeroProtocolo { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string DescricaoSolicitacao { get; set; }
        public int CodigoSituacaoSolicitacao { get; set; }
        public string SituacaoSolicitacao { get; set; }
    }
}
