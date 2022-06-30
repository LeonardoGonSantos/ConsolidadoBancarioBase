using ConsolidadoBancarioBase.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolidadoBancario.Base.Domain.Models
{
    public class Conta : EntidadeBase
    {
        public int ClientId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int Numero { get; set; }
        public int Digito { get; set; }
        public int Agencia { get; set; }
    }
}
