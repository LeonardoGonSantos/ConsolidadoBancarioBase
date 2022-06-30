using ConsolidadoBancarioBase.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolidadoBancario.Base.Domain.Models
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
    }
}
