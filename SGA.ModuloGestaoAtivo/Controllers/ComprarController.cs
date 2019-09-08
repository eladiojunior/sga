using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGA.ModuloGestaoAtivo.Models;
using SGA.ModuloGestaoAtivo.Models.Enums;
using SGA.ModuloGestaoAtivo.Service;
using SGA.ModuloGestaoAtivo.Service.Model;

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
                var listResultApi = _sgaAtivoApiClient.ListarSolicitacaoCompra(numeroProtocolo, situacao, hasExibirFechadas);
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

        [Authorize]
        public IActionResult Registrar()
        {
            SolicitacaoCompraModel model = new SolicitacaoCompraModel();
            model.DataSolicitacao = DateTime.Now.Date;
            model.CodigoSituacaoSolicitacao = (int)SituacaoSolicitacaoEnum.Solicitado;
            model.SituacaoSolicitacao = SituacaoSolicitacaoEnum.Solicitado.ToString();
            return View("Comprar", model);
        }

        [Authorize]
        public IActionResult Solicitar(SolicitacaoCompraModel model)
        {
            if (!ModelState.IsValid)
                return JsonResultErro(ModelState);

            try
            {

                //Recuperar o ativo para registrar a baixa;
                SolicitacaoCompraModelApi modelApi = new SolicitacaoCompraModelApi();
                modelApi.DataSolicitacao = model.DataSolicitacao;
                modelApi.DescricaoSolicitacao = model.DescricaoSolicitacao;
                modelApi.CodigoSituacaoSolicitacao = model.CodigoSituacaoSolicitacao;
                modelApi.SituacaoSolicitacao = model.SituacaoSolicitacao;
                modelApi.Responsavel = User.Identity.Name;

                string numeroProtocolo = _sgaAtivoApiClient.SolicitarCompraAtivo(modelApi);

                return JsonResultSucesso(numeroProtocolo, "Solicitação de compra de ativo registrada com sucesso.");

            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }

        }

    }
}