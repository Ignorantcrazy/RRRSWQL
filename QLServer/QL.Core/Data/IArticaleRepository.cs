using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QL.Core.Data
{
    public interface IArticaleRepository : IBaseRepository<Articale,int>
    {
        Task<List<Articale>> GetAll(int? classificationId,int? userId,string include1,string include2);
    }
}
