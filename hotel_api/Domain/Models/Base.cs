using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel_api.Domain.Models
{
    public abstract class  Base<T>
    {
        public T Id { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime CreatAt { get; private set; }
        public DateTime UpdateAt { get; set; }
        
        public Base(){
            Ativo = true;
            CreatAt = DateTime.UtcNow.AddHours(-3);
            UpdateAt = DateTime.UtcNow.AddHours(-3);
        }
    }
}