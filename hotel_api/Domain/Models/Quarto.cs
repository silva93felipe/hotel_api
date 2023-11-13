using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotel_api.Domain.Enums;

namespace hotel_api.Domain.Models
{
    public class Quarto : Base<int>
    {
        public string Numero { get; private set; }
        public StatusQuatro StatusQuarto { get; private set; }
        public TipoQuarto TipoQuarto { get; private set; }
        public bool IsSuite {get; private set;}

        public Quarto()
        {
            StatusQuarto = StatusQuatro.Disponivel;
        }

    }
}

