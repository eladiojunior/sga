using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGA.ModuloGestaoAtivo.Models;
using SGA.ModuloGestaoAtivo.Service;
using SGA.ModuloGestaoAtivo.Service.Model;

namespace SGA.ModuloGestaoAtivo.Controllers
{
    public class BaixarController : DefaultController
    {
        public BaixarController(IViewRenderService viewRenderService, ISgaAtivoApiClient sgaAtivoApiClient) 
            : base(viewRenderService, sgaAtivoApiClient) { }

        [Authorize]
        public IActionResult Listar()
        {
            return View();
        }

        [Authorize]
        public IActionResult CarregarBaixar(string idAtivo)
        {
            AtivoModel viewModel = new AtivoModel();
            try
            {
                var ativoEdicao = _sgaAtivoApiClient.ObterAtivo(idAtivo);
                viewModel = AtivoModel.ConvertToModel(ativoEdicao);
                return View("Baixar", viewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Listar");
            }
        }

        [Authorize]
        public async Task<IActionResult> ListarAtivos()
        {
            List<AtivoModel> viewModel = new List<AtivoModel>();
            try
            {
                var listResultApi = _sgaAtivoApiClient.ListarAtivos(string.Empty, false); ;
                if (listResultApi != null)
                {
                    foreach (var item in listResultApi.Where(w => w.BaixaAtivo == null))
                    {
                        viewModel.Add(AtivoModel.ConvertToModel(item));
                    }
                }
                var result = await _viewRenderService.RenderToStringAsync("Baixar/_ListaBaixar", viewModel);
                return JsonResultSucesso(result, string.Empty);
            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }
        }

        [Authorize]
        public IActionResult Registrar(BaixaAtivoModel model)
        {
            if (!ModelState.IsValid)
                return JsonResultErro(ModelState);

            try
            {

                //Recuperar o ativo para registrar a baixa;
                AtivoModelApi modelAtivoApi = _sgaAtivoApiClient.ObterAtivo(model.IdAtivo);
                if (modelAtivoApi.BaixaAtivo != null)
                {
                    string dataBaixa = modelAtivoApi.BaixaAtivo.Data.ToString("dd/MM/yyyy");
                    return JsonResultErro($"Ativo já baixado em [{dataBaixa}]");
                }

                BaixaAtivoModelApi baixaModelApi = new BaixaAtivoModelApi();
                baixaModelApi.Data = model.Data;
                baixaModelApi.Motivo = model.Motivo;
                baixaModelApi.Responsavel = User.Identity.Name;

                modelAtivoApi.BaixaAtivo = baixaModelApi;

                _sgaAtivoApiClient.GravarAtivo(modelAtivoApi);

                return JsonResultSucesso("Baixa do ativo registrado com sucesso.");

            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }

        }

    }
}