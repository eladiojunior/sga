using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGA.ModuloGestaoAtivo.Models;
using SGA.ModuloGestaoAtivo.Service;

namespace SGA.ModuloGestaoAtivo.Controllers
{
    public class ComprarController : DefaultController
    {
        public ComprarController(IViewRenderService viewRenderService, ISgaAtivoApiClient sgaAtivoApiClient)
            : base(viewRenderService, sgaAtivoApiClient) { }

        [Authorize]
        public IActionResult Listar()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> ListarSolicitacoes(string numeroProtocolo, int situacao, bool hasExibirFechadas)
        {
            List<SolicitacaoCompraModel> viewModel = new List<SolicitacaoCompraModel>();
            try
            {
                var listResultApi = _sgaAtivoApiClient.ListarSolicitacaoCompra(numeroProtocolo, situacao, hasExibirFechadas); ;
                if (listResultApi != null)
                {
                    foreach (var item in listResultApi)
                    {
                        viewModel.Add(SolicitacaoCompraModel.ConvertToModel(item));
                    }
                }
                var result = await _viewRenderService.RenderToStringAsync("Comprar/_ListaSolicitacao", viewModel);
                return JsonResultSucesso(result, string.Empty);
            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }
        }
        
    }
}