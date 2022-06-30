using Microsoft.EntityFrameworkCore;
using ConsolidadoBancarioBase.Domain.Entities.Base;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        private readonly ILogger _logger;
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
            _logger = Log.ForContext<SqlContext>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
        }

        private async Task Salvar()
        {
            try
            {
                var entries = ChangeTracker
                            .Entries()
                            .Where(e => e.Entity is EntidadeBase && (
                                   e.State == EntityState.Added ||
                                   e.State == EntityState.Modified));

                var dataAtual = DateTimeOffset.UtcNow;
                foreach (var entityEntry in entries)
                {
                    if (entityEntry.State == EntityState.Added)
                    {
                        entityEntry.Property("DataCriado").CurrentValue = dataAtual;
                        entityEntry.Property("DataAtualizado").CurrentValue = dataAtual;
                    }

                    if (entityEntry.State == EntityState.Modified)
                        entityEntry.Property("DataAtualizado").CurrentValue = dataAtual;
                }
                await SaveChangesAsync();

            }
            catch (Exception e)
            {
                _logger.Error($"{nameof(SqlContext)}: {e.Message}");
                throw;
            }
        }

        public async Task SendChangesAsync()
        {
            await Salvar();
        }

    }
}
