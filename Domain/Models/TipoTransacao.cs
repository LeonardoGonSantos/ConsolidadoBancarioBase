using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolidadoBancario.Base.Domain.Models
{
    public enum TipoTransacao
    {
        Deposito = 0,
        Saque = 1,
        TransferenciaEntreContas = 2
    }
}
