using System;
using System.ComponentModel.DataAnnotations;
using SGA.ModuloGestaoAtivo.Service.Model;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class BaixaAtivoModel
    {
        [Required]
        [Display(Name = "Id do Ativo")]
        public string IdAtivo { get; set; }

        [Required]
        [Display(Name = "Data da Baixa")]
        public DateTime Data { get; set; }

        [Required]
        [Display(Name = "Motivo da Baixa")]
        public string Motivo { get; set; }

        internal static BaixaAtivoModel ConvertToModel(BaixaAtivoModelApi modelApi)
        {
            BaixaAtivoModel model = new BaixaAtivoModel();
            model.Data = modelApi.Data;
            model.Motivo = modelApi.Motivo;
            return model;
        }
    }
}