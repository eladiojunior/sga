using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Service.Model
{
    public class AtivoModelApi
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int QtdDiasManutencao { get; set; }
        public DateTime? DataUltimaManutencao { get; set; }
        public DateTime DataRegistro { get; set; }
        public ICollection<ManutencaoAtivoModelApi> ManutencoesAtivo { get; set; }
        public BaixaAtivoModelApi BaixaAtivo { get; set; }
        public string Responsavel { get; set; }
    }
}
