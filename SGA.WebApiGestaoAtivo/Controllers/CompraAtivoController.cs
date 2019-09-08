using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGA.WebApiGestaoAtivo.Contexto.Entites;
using SGA.WebApiGestaoAtivo.Contexto.Replository;
using SGA.WebApiGestaoAtivo.Model;

namespace SGA.WebApiGestaoAtivo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraAtivoController : ControllerBase
    {
        private ISolicitacaoCompraAtivoRepository SolicitacaoCompraAtivoRepository { get; set; }

        public CompraAtivoController(ISolicitacaoCompraAtivoRepository repository)
        {
            SolicitacaoCompraAtivoRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<SolicitacaoCompraAtivoEntity> entites = await SolicitacaoCompraAtivoRepository.GetAllAsync();
            return Ok(SolicitacaoCompraAtivoModel.ConverterToListModel(entites));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await SolicitacaoCompraAtivoRepository.Get(id);
            if (item == null)
                return NotFound($"Solicitação de Compra de Ativo [{id}] não encontrada.");
            return Ok(SolicitacaoCompraAtivoModel.ConverterToModel(item));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SolicitacaoCompraAtivoModel solicitacao)
        {
            if (solicitacao == null)
                return BadRequest("Informações da solicitação de compra de novo ativo não informada.");
            var entity = SolicitacaoCompraAtivoModel.ConverterToEntity(solicitacao);
            await SolicitacaoCompraAtivoRepository.Create(entity);
            return Ok("Solicitação de compra de novo ativo registrada com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SolicitacaoCompraAtivoModel solicitacao)
        {
            if (solicitacao == null)
                return BadRequest("Informações da solicitação de compra de novo ativo não informada.");
            var entity = SolicitacaoCompraAtivoModel.ConverterToEntity(solicitacao);
            bool hasResult = await SolicitacaoCompraAtivoRepository.Update(entity);
            if (!hasResult)
                return NotFound("Não foi possível atualizar a solicitação de compra de novo ativo.");
            return Ok($"Solicitação de compra [{solicitacao.Id}] atualizado com sucesso.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            bool hasResult = await SolicitacaoCompraAtivoRepository.Delete(id);
            if (!hasResult)
                return NotFound("Não foi possível remover a solicitação de compra de novo ativo.");
            return Ok($"Solicitação de compra [{id}] removido com sucesso.");
        }

    }
}