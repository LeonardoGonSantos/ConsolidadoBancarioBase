using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConsolidadoBancarioBase.Domain.Entities.Base;

namespace Infra.Data.Sql.Mappings.Base
{
    public class MapBase<T> : IEntityTypeConfiguration<T>
        where T : EntidadeBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.DataCriado).IsRequired();
            builder.Property(c => c.DataAtualizado).IsRequired();
        }
    }
}
