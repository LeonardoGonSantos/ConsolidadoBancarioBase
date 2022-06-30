using ConsolidadoBancarioBase.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolidadoBancario.Base.Domain.Models
{
    public class Saldo : EntidadeBase
    {
        public int ContaId { get; set; }
        public virtual Conta Conta { get; set; }    
        public decimal Valor { get; set; }
    }
}
