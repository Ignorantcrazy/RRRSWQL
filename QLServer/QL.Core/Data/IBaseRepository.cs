using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QL.Core.Data
{
    public interface IBaseRepository<TEntity,in TKey> where TEntity : class
    {
        Task<List<TEntity>> GetAll();

        Task<List<TEntity>> GetAll(string include);

        Task<TEntity> Get(TKey id);

        Task<TEntity> Get(TKey id,string include);
    }
}
