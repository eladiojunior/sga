using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class FiltroAtivoModel
    {
        [Display(Description = "Nome ou parte")]
        public string Nome { get; set; }

        [Display(Description = "Exibir os ativos baixados")]
        public bool HasBaixados { get; set; }
    }
}
