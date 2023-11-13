using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using hotel_api.Domain.Models;

namespace hotel_api.Services
{
    public class PagamentoService
    {
        const string URL_BASE_API_FINANCEIRO = "http://localhost:5222/api/";

        private readonly HttpClient _httpClient;
        public PagamentoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async void GerarCobranca(Reserva reserva){

            //var a = await _httpClient.PostAsync(URL_BASE_API_FINANCEIRO);
        }
    }
}