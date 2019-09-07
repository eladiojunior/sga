using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA.WebApiGestaoAtivo.Contexto.Entites;

namespace SGA.WebApiGestaoAtivo.Model
{
    public class BaixaAtivoModel
    {
        public DateTime Data { get; set; }
        public string Motivo { get; set; }
        public string Responsavel { get; set; }

        internal static BaixaAtivoModel ConverterToModel(BaixaAtivoEntity entity)
        {
            if (entity == null)
                return null;
            BaixaAtivoModel model = new BaixaAtivoModel();
            model.Data = entity.Data.DateTime;
            model.Motivo = entity.Motivo;
            model.Responsavel = entity.Responsavel;
            return model;
        }

        internal static BaixaAtivoEntity ConverterToEntity(BaixaAtivoModel model)
        {
            if (model == null)
                return null;
            BaixaAtivoEntity entity = new BaixaAtivoEntity();
            entity.Data = model.Data;
            entity.Motivo = model.Motivo;
            entity.Responsavel = model.Responsavel;
            return entity;
        }
    }
}
