using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotel_api.Domain.Models;
using hotel_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace hotel_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly HttpClient _httpCliente;   
        private readonly PagamentoService _pagamentoService;
        public ReservaController()
        {
            _httpCliente = new HttpClient();
            _pagamentoService = new PagamentoService(_httpCliente);
        }


        [HttpPost]
        public void Criar([FromBody] Reserva reserva){
            //_pagamentoService.GerarCobranca();

        }
    }
}