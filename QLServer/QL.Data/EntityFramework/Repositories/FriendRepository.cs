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
    public class FriendRepository : BaseRepository<Friend,int>,IFriendRepository
    {
        private QLContext _db;
        public FriendRepository() { }
        public FriendRepository(QLContext db) : base(db) => _db = db;

        public Task<List<Friend>> GetFriendBySex(int sex)
        {
            return _db.Friends.Where(x => x.Sex == sex).ToListAsync();
        }
    }
}
