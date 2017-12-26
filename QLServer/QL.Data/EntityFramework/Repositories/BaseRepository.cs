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

        public TEntity Add(TEntity entity)
        {
            _DB.Set<TEntity>().Add(entity);
            return entity;
        }

        public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entity)
        {
            _DB.Set<TEntity>().AddRange(entity);
            return entity;
        }

        public void Delete(TKey id)
        {
            var entity = new TEntity {Id = id };
            _DB.Set<TEntity>().Attach(entity);
            _DB.Set<TEntity>().Remove(entity);
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

        public async Task<bool> SaveChangesAsync()
        {
            return (await _DB.SaveChangesAsync()) > 0;
        }

        public void Update(TEntity entity)
        {
            _DB.Set<TEntity>().Attach(entity);
            _DB.Entry(entity).State = EntityState.Modified;
        }
    }
}
