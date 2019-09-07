using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA.WebApiGestaoAtivo.Contexto.Entites;

namespace SGA.WebApiGestaoAtivo.Model
{
    public class ManutencaoAtivoModel
    {
        public DateTime Data { get; set; }
        public bool HasPreventiva { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }

        internal static List<ManutencaoAtivoModel> ConverterToListModel(ICollection<ManutencaoAtivoEntity> listEntites)
        {
            List<ManutencaoAtivoModel> listModel = new List<ManutencaoAtivoModel>();
            if (listEntites == null)
                return listModel;

            foreach (var item in listEntites)
            {
                listModel.Add(ConvertToModel(item));
            }
            return listModel;
        }

        internal static ICollection<ManutencaoAtivoEntity> ConverterToListEntity(ICollection<ManutencaoAtivoModel> listModel)
        {
            List<ManutencaoAtivoEntity> listEntites = new List<ManutencaoAtivoEntity>();
            if (listModel == null)
                return listEntites;

            foreach (var item in listModel)
            {
                listEntites.Add(ConvertToEntity(item));
            }
            return listEntites;
        }

        internal static ManutencaoAtivoModel ConvertToModel(ManutencaoAtivoEntity entity)
        {
            if (entity == null)
                return null;
            ManutencaoAtivoModel model = new ManutencaoAtivoModel();
            model.Data = entity.Data.DateTime;
            model.HasPreventiva = entity.HasPreventiva;
            model.Descricao = entity.Descricao;
            model.Responsavel = entity.Responsavel;
            return model;
        }
        internal static ManutencaoAtivoEntity ConvertToEntity(ManutencaoAtivoModel model)
        {
            if (model == null)
                return null;
            ManutencaoAtivoEntity entity = new ManutencaoAtivoEntity();
            entity.Data = model.Data;
            entity.HasPreventiva = model.HasPreventiva;
            entity.Descricao = model.Descricao;
            entity.Responsavel = model.Responsavel;
            return entity;
        }

    }
}
