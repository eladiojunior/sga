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
        public string Tipo { get; set; }
        public int QtdDiasManutencao { get; set; }
        public DateTime? DataUltimaManutencao { get; set; }
        public ICollection<ManutencaoAtivoModel> ManutencoesAtivo { get; set; }
        public BaixaAtivoModel BaixaAtivo { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataRegistro { get; set; }

        internal static IEnumerable<AtivoModel> ConverterToListModel(IEnumerable<AtivoEntity> ativosEntity)
        {
            List<AtivoModel> ativosModel = new List<AtivoModel>();
            if (ativosEntity == null)
                return ativosModel;
            foreach (var item in ativosEntity)
            {
                ativosModel.Add(ConverterToModel(item));
            }
            return ativosModel;
        }

        internal static AtivoModel ConverterToModel(AtivoEntity entity)
        {
            if (entity == null)
                return null;

            AtivoModel model = new AtivoModel();
            model.Id = entity.Id.ToString();
            model.Nome = entity.Nome;
            model.Tipo = entity.Tipo;
            model.QtdDiasManutencao = entity.QtdDiasManutencao;
            if (entity.DataUltimaManutencao.HasValue)
                model.DataUltimaManutencao = entity.DataUltimaManutencao.Value.DateTime;
            model.Responsavel = entity.Responsavel;
            model.BaixaAtivo = BaixaAtivoModel.ConverterToModel(entity.Baixa);
            model.ManutencoesAtivo = ManutencaoAtivoModel.ConverterToListModel(entity.Manutencoes);
            model.DataRegistro = entity.DataRegistro.DateTime;
            return model;
        }

        internal static AtivoEntity ConverterToEntity(AtivoModel model)
        {
            if (model == null)
                return null;
            AtivoEntity entity = new AtivoEntity();
            if (!string.IsNullOrEmpty(model.Id))
                entity.Id = new MongoDB.Bson.ObjectId(model.Id);
            entity.Nome = model.Nome;
            entity.Tipo = model.Tipo;
            entity.QtdDiasManutencao = model.QtdDiasManutencao;
            if (model.DataUltimaManutencao.HasValue)
                entity.DataUltimaManutencao = model.DataUltimaManutencao.Value;
            entity.Responsavel = model.Responsavel;
            entity.Baixa = BaixaAtivoModel.ConverterToEntity(model.BaixaAtivo);
            entity.Manutencoes = ManutencaoAtivoModel.ConverterToListEntity(model.ManutencoesAtivo);
            entity.DataRegistro = model.DataRegistro;
            return entity;
        }

    }
}
