using QL.Core.Data;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.Data.EntityFramework.Repositories
{
    public class UserRepository : BaseRepository<User,int> , IUserRepository
    {
        public UserRepository() { }
        public UserRepository(QLContext db) : base(db) { }
    }
}
