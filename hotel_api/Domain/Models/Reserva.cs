using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;

namespace hotel_api.Domain.Models
{
    public class Reserva : Base<int>
    {
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataSaida {get; private set;}
        public int QuartoId { get; private set; }
        public Quarto Quarto {get; private set;}
        public int HospedeId {get; private set;}
        public Hospede Hospede {get; private set;}
        public double ValorInicial {get; private set;}
        
        public Reserva(DateTime dataEntrada)
        {
            this.DataEntrada = dataEntrada;
            this.Quarto = new();
            this.Hospede = new();
        }
    }
}