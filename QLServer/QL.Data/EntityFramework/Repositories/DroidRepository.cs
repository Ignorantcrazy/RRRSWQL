using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using QL.Core.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QL.Data.EntityFramework.Repositories
{
    public class DroidRepository : IDroidRepository
    {
        private QLContext _DB { get; set; }

        public DroidRepository(QLContext db)
        {
            _DB = db;
        }
        public Task<Droid> Get(int id)
        {
            return _DB.Droids.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
