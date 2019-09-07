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
    public class ManterController : DefaultController
    {
        public ManterController(IViewRenderService viewRenderService, ISgaAtivoApiClient sgaAtivoApiClient) 
            : base(viewRenderService, sgaAtivoApiClient) { }

        [Authorize]
        public IActionResult Listar()
        {
            return View();
        }

        [Authorize]
        public IActionResult CarregarManter(string idAtivo)
        {
            AtivoModel viewModel = new AtivoModel();
            try
            {
                var ativoEdicao = _sgaAtivoApiClient.ObterAtivo(idAtivo);
                viewModel = AtivoModel.ConvertToModel(ativoEdicao);
                return View("Manter", viewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Manter");
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
                    foreach (var item in listResultApi)
                    {
                        viewModel.Add(AtivoModel.ConvertToModel(item));
                    }
                }
                var result = await _viewRenderService.RenderToStringAsync("Manter/_ListaManutencao", viewModel);
                return JsonResultSucesso(result, string.Empty);
            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }
        }

        [Authorize]
        public IActionResult Registrar(ManutencaoAtivoModel model)
        {
            if (!ModelState.IsValid)
                return JsonResultErro(ModelState);

            try
            {

                //Recuperar o ativo para registrar a manutenção;
                AtivoModelApi modelAtivoApi = _sgaAtivoApiClient.ObterAtivo(model.IdAtivo);
                if (modelAtivoApi.ManutencoesAtivo == null)
                    modelAtivoApi.ManutencoesAtivo = new List<ManutencaoAtivoModelApi>();

                ManutencaoAtivoModelApi manutencaoModelApi = new ManutencaoAtivoModelApi();
                manutencaoModelApi.Data = model.Data;
                manutencaoModelApi.Descricao = model.Descricao;
                manutencaoModelApi.HasPreventiva = model.HasPreventiva;
                manutencaoModelApi.Responsavel = User.Identity.Name;

                modelAtivoApi.ManutencoesAtivo.Add(manutencaoModelApi);
                modelAtivoApi.DataUltimaManutencao = model.Data;

                _sgaAtivoApiClient.GravarAtivo(modelAtivoApi);

                return JsonResultSucesso("Manutenção em ativo registrado com sucesso.");

            }
            catch (Exception erro)
            {
                return JsonResultErro(erro);
            }

        }

    }
}