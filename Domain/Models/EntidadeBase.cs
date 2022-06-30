using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsolidadoBancarioBase.Domain.Entities.Base
{
    [ExcludeFromCodeCoverage]
    public abstract class EntidadeBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTimeOffset DataCriado { get; set; }
        public DateTimeOffset DataAtualizado { get; set; }
    }
}
