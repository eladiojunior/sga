using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA.WebApiGestaoAtivo.Contexto.Entites;

namespace SGA.WebApiGestaoAtivo.Model
{
    public class AtivoModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataRegistro { get; set; }

        internal static IEnumerable<AtivoModel> Converter(IEnumerable<AtivoEntity> ativosEntity)
        {
            List<AtivoModel> ativosModel = new List<AtivoModel>();
            foreach (var item in ativosEntity)
            {
                var model = new AtivoModel();
                model.Id = item.Id.ToString();
                model.Nome = item.Nome;
                model.DataRegistro = item.DataRegistro.DateTime;
            }
            return ativosModel;
        }

        internal static AtivoEntity Converter(AtivoModel model)
        {
            AtivoEntity entity = new AtivoEntity();
            entity.Nome = model.Nome;
            entity.DataRegistro = model.DataRegistro;
            return entity;
        }

    }
}
