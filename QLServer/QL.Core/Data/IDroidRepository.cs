using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QL.Core.Data
{
    public interface IDroidRepository
    {
        Task<Droid> Get(int id);
    }
}
