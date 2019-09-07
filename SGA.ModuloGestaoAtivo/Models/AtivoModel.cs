using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SGA.ModuloGestaoAtivo.Service.Model;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class AtivoModel
    {
        public string Id { get; set; }
        [Display(Name = "Nome do ativo")]
        public string Nome { get; set; }
        [Display(Name = "Tipo do ativo")]
        public string Tipo { get; set; }
        [Display(Name = "Período de manutenção (em dias)")]
        public int QtdDiasPeriodoManutencao { get; set; }
        public DateTime? UltimaManutencao { get; set; }
        public string Responsavel { get; set; }

        public BaixaAtivoModel Baixa { get; set; }
        public List<ManutencaoAtivoModel> Manutencoes { get; set; }

        public bool HasBaixado { get; set; }
        public bool HasManutencoes { get; set; }

        internal static AtivoModel ConvertToModel(AtivoModelApi modelApi)
        {
            var model = new AtivoModel();
            model.Id = modelApi.Id;
            model.Nome = modelApi.Nome;
            model.Tipo = modelApi.Tipo;
            model.QtdDiasPeriodoManutencao = modelApi.QtdDiasManutencao;
            model.UltimaManutencao = modelApi.DataUltimaManutencao;
            model.Responsavel = modelApi.Responsavel;

            //Verificar se ativo baixado...
            model.HasBaixado = (modelApi.BaixaAtivo != null);
            if (model.HasBaixado)
                model.Baixa = BaixaAtivoModel.ConvertToModel(modelApi.BaixaAtivo);
            
            //Verificar se ativo possui manutenções...
            model.HasManutencoes = (modelApi.ManutencoesAtivo != null && modelApi.ManutencoesAtivo.Any());
            if (model.HasManutencoes)
                model.Manutencoes = ManutencaoAtivoModel.ConvertToModels(modelApi.ManutencoesAtivo);

            return model;
        }
    }
}
