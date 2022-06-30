﻿using ConsolidadoBancario.Base.Domain.Models;
using Infra.Data.Sql.Mappings.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Sql.Mappings
{
    public class HistoricoDeSaldoMapping : MapBase<HistoricoDeSaldo>
    {
        public override void Configure(EntityTypeBuilder<HistoricoDeSaldo> builder)
        {
            base.Configure(builder);
        }
    }
}
