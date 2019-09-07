using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SGA.ModuloGestaoAtivo.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SGA.ModuloGestaoAtivo.Service
{
    public interface ISgaAtivoApiClient
    {
        ICollection<AtivoModelApi> ListarAtivos(string nome, bool hasBaixados);
        void GravarAtivo(AtivoModelApi modelApi);
        AtivoModelApi ObterAtivo(string idAtivo);
        ICollection<SolicitacaoCompraModelApi> ListarSolicitacaoCompra(string numeroProtocolo, int situacao, bool hasExibirFechadas);
    }

    public class SgaAtivoApiClient : ISgaAtivoApiClient
    {
        private HttpClient _client;
        private IConfiguration _configuration;
        public SgaAtivoApiClient(HttpClient client, IConfiguration configuration)
        {

            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            _configuration = configuration;

        }

        /// <summary>
        /// Gravar as informações do Ativo.
        /// </summary>
        /// <param name="ativoModel">Dados do ativo a ser gravado.</param>
        public void GravarAtivo(AtivoModelApi ativoModel)
        {
            try
            {

                string baseURL = _configuration.GetSection("SGA_AtivoAPI:BaseURL").Value;
                string key = _configuration.GetSection("SGA_AtivoAPI:Key").Value;
                if (!string.IsNullOrEmpty(key))
                    baseURL += $"?api_key={key}";

                ativoModel.DataRegistro = DateTime.Now;
                StringContent content = new StringContent(JsonConvert.SerializeObject(ativoModel), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response;
                if (string.IsNullOrEmpty(ativoModel.Id))
                    response = _client.PostAsync(baseURL, content).Result;
                else
                    response = _client.PutAsync(baseURL, content).Result;

                response.EnsureSuccessStatusCode();

            }
            catch (Exception erro)
            {
                throw new HttpRequestException("Erro ao gravar ativo.", erro);
            }
        }

        /// <summary>
        /// Recupera a listra de Ativos via API;
        /// </summary>
        /// <param name="nome">Filtro por nome ou parte do nome.</param>
        /// <param name="hasBaixados">Indicador de ativo baixado.</param>
        /// <returns></returns>
        public ICollection<AtivoModelApi> ListarAtivos(string nome, bool hasBaixados)
        {

            ICollection<AtivoModelApi> lista = new List<AtivoModelApi>();
            try
            {

                string baseURL = _configuration.GetSection("SGA_AtivoAPI:BaseURL").Value;
                string key = _configuration.GetSection("SGA_AtivoAPI:Key").Value;
                if (!string.IsNullOrEmpty(key))
                    baseURL += $"?api_key={key}";
                var response = _client.GetAsync(baseURL).Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<ICollection<AtivoModelApi>>(conteudo);
                return lista;

            }
            catch (Exception erro)
            {
                throw new HttpRequestException("Erro ao recuperar a lista de ativos.", erro);
            }

        }

        /// <summary>
        /// Recupera a lista de solicitações de comprar realizada pelo módulo.
        /// </summary>
        /// <param name="numeroProtocolo">Número do protocolo.</param>
        /// <param name="situacao">Situacao</param>
        /// <param name="hasExibirFechadas">Exibir fechadas.</param>
        /// <returns></returns>
        public ICollection<SolicitacaoCompraModelApi> ListarSolicitacaoCompra(string numeroProtocolo, int situacao, bool hasExibirFechadas)
        {
            List<SolicitacaoCompraModelApi> listResult = new List<SolicitacaoCompraModelApi>();
            return listResult;
        }

        /// <summary>
        /// Recupera um ativo pelo seu ID.
        /// </summary>
        /// <param name="idAtivo">Identificador do ativo.</param>
        /// <returns></returns>
        public AtivoModelApi ObterAtivo(string idAtivo)
        {
            try
            {

                string baseURL = _configuration.GetSection("SGA_AtivoAPI:BaseURL").Value;
                baseURL += $"{idAtivo}";

                string key = _configuration.GetSection("SGA_AtivoAPI:Key").Value;
                if (!string.IsNullOrEmpty(key))
                    baseURL += $"&api_key={key}";

                var response = _client.GetAsync(baseURL).Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;
                var ativo = JsonConvert.DeserializeObject<AtivoModelApi>(conteudo);
                return ativo;

            }
            catch (Exception erro)
            {
                throw new HttpRequestException($"Erro ao recuperar ativo com id [{idAtivo}].", erro);
            }
        }
    }
}
