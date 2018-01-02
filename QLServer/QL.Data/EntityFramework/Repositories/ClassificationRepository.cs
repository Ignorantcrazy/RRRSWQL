using QL.Core.Data;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.Data.EntityFramework.Repositories
{
    public class ClassificationRepository : BaseRepository<Classification,int>, IClassificationRepository
    {
        public ClassificationRepository() { }

        public ClassificationRepository(QLContext db):base(db) { }
    }
}
