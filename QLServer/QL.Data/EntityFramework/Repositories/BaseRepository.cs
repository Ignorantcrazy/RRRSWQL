using Microsoft.EntityFrameworkCore;
using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QL.Data.EntityFramework.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> 
        where TEntity : class, IEntity<TKey>, new()
    {
        protected DbContext _DB;
        public BaseRepository() { }
        public BaseRepository(DbContext db)
        {
            _DB = db;
        }
        public Task<TEntity> Get(TKey id)
        {
            return _DB.Set<TEntity>().SingleOrDefaultAsync(c => c.Id.Equals(id));
        }

        public Task<TEntity> Get(TKey id, string include)
        {
            return _DB.Set<TEntity>().Include(include).SingleOrDefaultAsync(c => c.Id.Equals(id));
        }

        public Task<List<TEntity>> GetAll()
        {
            return _DB.Set<TEntity>().ToListAsync();
        }

        public Task<List<TEntity>> GetAll(string include)
        {
            return _DB.Set<TEntity>().Include(include).ToListAsync();
        }
    }
}
