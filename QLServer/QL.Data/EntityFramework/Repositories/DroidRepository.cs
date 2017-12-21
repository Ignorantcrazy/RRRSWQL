using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using QL.Core.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QL.Data.EntityFramework.Repositories
{
    public class DroidRepository : BaseRepository<Droid,int>, IDroidRepository
    {
        public DroidRepository() { }
        public DroidRepository(QLContext db) : base(db) { }
    }
}
