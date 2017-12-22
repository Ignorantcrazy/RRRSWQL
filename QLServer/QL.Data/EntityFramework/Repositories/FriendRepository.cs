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

        public Task<List<Friend>> GetFriendBySex(int sex, string include)
        {
            return _db.Friends.Include(include).Where(x => x.Sex == sex).ToListAsync();
        }

        public Task<List<Friend>> GetFriendsByDroidId(int id,string include)
        {
            return _db.Friends.Include(include).Where(x => x.Droid.Id == id).ToListAsync();
        }
    }
}
