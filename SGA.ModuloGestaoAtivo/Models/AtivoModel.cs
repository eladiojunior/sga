using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Models
{
    public class AtivoModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int QtdDiasPeriodoManutencao { get; set; }
        public DateTime? UltimaManutencao { get; set; }
    }
}
