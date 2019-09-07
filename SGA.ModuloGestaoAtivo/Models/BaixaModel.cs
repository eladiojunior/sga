using System;
using SGA.ModuloGestaoAtivo.Service.Model;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class BaixaAtivoModel
    {
        public DateTime Data { get; set; }
        public string Motivo { get; set; }
        public string Responsavel { get; set; }

        internal static BaixaAtivoModel ConvertToModel(BaixaAtivoModelApi modelApi)
        {
            BaixaAtivoModel model = new BaixaAtivoModel();
            model.Data = modelApi.Data;
            model.Motivo = modelApi.Motivo;
            model.Responsavel = modelApi.Responsavel;
            return model;
        }
    }
}