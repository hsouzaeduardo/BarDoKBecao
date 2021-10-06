using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarDoKBecao.Infra.Repositorio
{
    public interface IRepo<T> where T : class
    {
        void Add(T entidade);
        void Edit(T entidade);
        void Delete(T entidade);
        T Get(Guid id);
        Task<IEnumerable<T>> Get();
        Task<int> Count();

    }
}
