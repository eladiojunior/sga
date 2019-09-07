using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Service.Model
{
    public class ManutencaoAtivoModelApi
    {
        public DateTime Data { get; set; }
        public bool HasPreventiva { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
    }
}
