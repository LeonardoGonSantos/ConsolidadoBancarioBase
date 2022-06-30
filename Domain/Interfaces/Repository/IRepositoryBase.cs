using ConsolidadoBancarioBase.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntidade> : IDisposable where TEntidade : EntidadeBase
    {
        Task<int> Incluir(TEntidade entidade);
        Task Alterar(TEntidade entidade);
        Task<TEntidade> SelecionarPorId(int id);
    }
}
