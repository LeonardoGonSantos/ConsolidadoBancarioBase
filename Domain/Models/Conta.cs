using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolidadoBancario.Base.Domain.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int Numero { get; set; }
        public int Digito { get; set; }
        public int Agencia { get; set; }
    }
}
