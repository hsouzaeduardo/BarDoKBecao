using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarDoKBecao.Infra.Repositorio
{
    public class RepoSQLDB<T> : IRepo<T> where T : class
    {
        internal readonly Contexto.Contexto _ctx;
        internal readonly DbSet<T> _tabelas;

        public RepoSQLDB(Contexto.Contexto ctx)
        {
            _ctx = ctx;
            _tabelas = _ctx.Set<T>();
        }

        public void Add(T entidade)
        {
            _tabelas.Add(entidade);
            _ctx.SaveChanges();
        }

        public async Task<int> Count()
        {
            return await _tabelas.CountAsync();

        }

        public void Delete(T entidade)
        {
            _tabelas.Remove(entidade);
            _ctx.SaveChanges();
        }

        public void Edit(T entidade)
        {
            _tabelas.Update(entidade);
            _ctx.SaveChanges();
        }

        public T Get(Guid id)
        {
            return _tabelas.Find(id);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _tabelas.ToListAsync();
        }
    }
}
