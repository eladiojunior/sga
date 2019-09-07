using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Service.Model
{
    public class BaixaAtivoModelApi
    {
        public DateTime Data { get; set; }
        public string Motivo { get; set; }
        public string Responsavel { get; set; }
    }
}
