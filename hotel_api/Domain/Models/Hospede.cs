using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotel_api.Domain.Enums;
using ProtoBuf;

namespace hotel_api.Domain.Models
{
    [ProtoContract]
    public class Hospede
    {
     /*    [ProtoMember(1)]
        public int Id { get; private set; }
        [ProtoMember(2)]
        public bool Ativo { get; private set; }
        [ProtoMember(3)]
        public DateTime CreatAt { get; private set; }
        */
        [ProtoMember(4)] 
        public string Name { get; set; }
        [ProtoMember(5)]
        public Sexo Sexo { get; set; }
        [ProtoMember(6)]
        public string NumeroDocumento { get; set; }

        /* public Hospede()
        {
            Ativo = true;
            Id = 1;
            CreatAt = DateTime.Now;
        } */

    }
}