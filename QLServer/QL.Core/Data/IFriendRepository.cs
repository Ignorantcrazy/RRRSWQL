using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QL.Core.Data
{
    public interface IFriendRepository : IBaseRepository<Friend,int>
    {
        Task<List<Friend>> GetFriendBySex(int sex);

        Task<List<Friend>> GetFriendBySex(int sex,string include);
        Task<List<Friend>> GetFriendsByDroidId(int id, string include);
    }
}
