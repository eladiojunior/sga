using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGA.ModuloGestaoAtivo.Models;
using SGA.ModuloGestaoAtivo.Service;
using SGA.ModuloGestaoAtivo.Service.Model;

namespace SGA.ModuloGestaoAtivo.Controllers
{
    public class AtivoController : DefaultController
    {

        public AtivoController(IViewRenderService viewRenderService, ISgaAtivoApiClient sgaAtivoApiClient) 
            : base(viewRenderService, sgaAtivoApiClient) { }

        [Authorize]
        public IActionResult Listar()
        {
            return View();
        }
        [Authorize]
        public IActionResult Registrar()
        {
            return View();
        }

        [Authorize]
        public IActionResult CarregarEdicao(string idAtivo)
        {
            AtivoModel viewModel = new AtivoModel();

            try
            {
                var ativoEdicao = _sgaAtivoApiClient.ObterAtivo(idAtivo);
                viewModel = AtivoModel.ConvertToModel(ativoEdicao);
                return View("Editar", viewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Listar");
            }
        }
        
        [Authorize]
        public IActionResult Gravar(AtivoModel model)
        {
            if (!ModelState.IsValid)
                return JsonResultErro(ModelState);

            AtivoModelApi modelApi = new AtivoModelApi();
            if (!string.IsNullOrEmpty(model.Id))
                modelApi.Id = model.Id;
            modelApi.Nome = model.Nome;
            modelApi.Tipo = model.Tipo;
            modelApi.QtdDiasManutencao = model.QtdDiasPeriodoManutencao;
            modelApi.Responsavel = User.Identity.Name;
            try
            {

                _sgaAtivoApiClient.GravarAtivo(modelApi);
                return JsonResultSucesso("Ativo registrado com sucesso.");

            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }

        }

        [Authorize]
        public async Task<IActionResult> ListarAtivos(FiltroAtivoModel model)
        {
            List<AtivoModel> viewModel = new List<AtivoModel>();
            try
            {
                var listResultApi = _sgaAtivoApiClient.ListarAtivos(model.Nome, model.HasBaixados);
                if (listResultApi != null)
                {
                    foreach (var item in listResultApi)
                    {
                        viewModel.Add(AtivoModel.ConvertToModel(item));
                    }
                }
                var result = await _viewRenderService.RenderToStringAsync("Ativo/_ListaAtivo", viewModel);
                return JsonResultSucesso(result, string.Empty);
            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }
        }

    }
}