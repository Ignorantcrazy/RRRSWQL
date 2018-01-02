using Microsoft.EntityFrameworkCore;
using QL.Core.Data;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.Data.EntityFramework.Repositories
{
    public class ArticaleRepository : BaseRepository<Articale,int>, IArticaleRepository
    {
        private QLContext _db;
        public ArticaleRepository() { }
        public ArticaleRepository(QLContext db):base(db)
        {
            this._db = db;
        }

        public async Task<List<Articale>> GetAll(int? classificationId, int? userId, string include1,string include2)
        {
            var articles = await _db.Set<Articale>().Include(include1).Include(include2).ToListAsync();
            if (articles.Count > 0 && classificationId.HasValue)
            {
                articles = articles.Where(m => m.Classification.Id == classificationId).ToList();
            }
            if (articles.Count > 0 && userId.HasValue)
            {
                articles = articles.Where(m => m.User.Id == userId).ToList();
            }
            return articles;
        }
    }
}
