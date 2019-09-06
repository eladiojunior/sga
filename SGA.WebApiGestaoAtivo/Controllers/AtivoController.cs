using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGA.WebApiGestaoAtivo.Contexto.Entites;
using SGA.WebApiGestaoAtivo.Contexto.Replository;
using SGA.WebApiGestaoAtivo.Model;

namespace SGA.WebApiGestaoAtivo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtivoController : ControllerBase
    {
        private IAtivoRepository AtivoRepository { get; set; }
        public AtivoController(IAtivoRepository repository)
        {
            AtivoRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<AtivoEntity> ativosEntity = await AtivoRepository.GetAllAtivosAsync();
            return Ok(AtivoModel.Converter(ativosEntity));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await AtivoRepository.GetAtivo(id);
            if (item == null)
                return NotFound(string.Format("Ativo [{0}] não encontrado.", id));
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AtivoModel ativo)
        {
            if (ativo == null)
                return BadRequest("Informações do Ativo não informado.");
            var ativoEntity = AtivoModel.Converter(ativo);
            await AtivoRepository.Create(ativoEntity);
            return Ok("Ativo registrado com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AtivoModel ativo)
        {
            if (ativo == null)
                return BadRequest("Informações do Ativo não informado.");
            var ativoEntity = AtivoModel.Converter(ativo);
            bool hasResult = await AtivoRepository.Update(ativoEntity);
            if (!hasResult)
                return NotFound("Não foi possível atualizar o Ativo.");
            return Ok(string.Format("Ativo [{0}] atualizado com sucesso.", ativo.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            bool hasResult = await AtivoRepository.Delete(id);
            if (!hasResult)
                return NotFound("Não foi possível remover o Ativo.");
            return Ok(string.Format("Ativo [{0}] removido com sucesso.", id));
        }

    }
}
