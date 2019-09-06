using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGA.ModuloGestaoAtivo.Controllers
{
    public class AtivoController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }
        public IActionResult Manter()
        {
            return View();
        }
        public IActionResult Comprar()
        {
            return View();
        }
        public IActionResult Baixar()
        {
            return View();
        }
    }
}