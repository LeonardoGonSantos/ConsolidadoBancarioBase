using ConsolidadoBancarioBase.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolidadoBancario.Base.Domain.Models
{
    public class HistoricoDeSaldo : EntidadeBase
    {
        public int ContaId { get; set; }
        public virtual Conta Conta { get; set; }
        public int SaldoId { get; set; }
        public virtual Saldo Saldo { get; set; }
        public decimal ValorTransacao { get; set; }
        public decimal ValorResultanteEmConta { get; set; }
        public TipoTransacao TipoTransacao { get; set;}
    }
}
