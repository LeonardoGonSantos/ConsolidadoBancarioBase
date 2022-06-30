using Microsoft.EntityFrameworkCore;
using ConsolidadoBancarioBase.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Data.Context;
using Domain.Interfaces.Repository;

namespace Infra.Data.Sql.Repository.Base
{
    public class RepositoryBase<TEntidade> : IRepositoryBase<TEntidade>
         where TEntidade : EntidadeBase
    {
        protected readonly Context.SqlContext context;

        public RepositoryBase(Context.SqlContext context) : base()
        {
            this.context = context;
        }

        public async Task Alterar(TEntidade entidade)
        {
            context.Set<TEntidade>().Attach(entidade);
            context.Entry(entidade).State = EntityState.Modified;
            await context.SendChangesAsync();
        }

        public async Task<int> Incluir(TEntidade entidade)
        {
            var id = context.Set<TEntidade>().Add(entidade).Entity.Id;
            await context.SendChangesAsync();
            return id;
        }

        public async Task<TEntidade> SelecionarPorId(int id)
        {
            return await context.Set<TEntidade>().FindAsync(id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            context?.Dispose();
        }
    }
}
