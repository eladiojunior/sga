using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SGA.ModuloGestaoAtivo.Service.Model;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class ManutencaoAtivoModel
    {
        [Required]
        [Display(Name = "Id do Ativo")]
        public string IdAtivo { get; set; }

        [Required]
        [Display(Name="Data da Manutenção")]
        public DateTime Data { get; set; }

        [Required]
        [Display(Name = "Manutenção Preventiva?")]
        public bool HasPreventiva { get; set; }

        [Required]
        [Display(Name = "Descrição da Manutenção")]
        public string Descricao { get; set; }

        internal static List<ManutencaoAtivoModel> ConvertToModels(ICollection<ManutencaoAtivoModelApi> listModelApi)
        {
            List<ManutencaoAtivoModel> listModel = new List<ManutencaoAtivoModel>();
            foreach (var item in listModelApi)
            {
                listModel.Add(ManutencaoAtivoModel.ConvertToModel(item));
            }
            return listModel;
        }

        internal static ManutencaoAtivoModel ConvertToModel(ManutencaoAtivoModelApi modelApi)
        {
            ManutencaoAtivoModel model = new ManutencaoAtivoModel();
            model.Data = modelApi.Data;
            model.HasPreventiva = modelApi.HasPreventiva;
            model.Descricao = modelApi.Descricao;
            return model;
        }
    }
}