using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QL.Core.Models;
using System.Linq;
using QL.Core.Data;

namespace QL.Data.InMemory
{
    public class DroidRepository : IDroidRepository
    {
        private List<Droid> _droids = new List<Droid>();
        public Task<Droid> Get(int id)
        {
            return Task.FromResult(_droids.FirstOrDefault(droid => droid.Id == id));
        }
    }
}
