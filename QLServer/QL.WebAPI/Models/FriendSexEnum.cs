using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class FriendSexEnum : EnumerationGraphType
    {
        public FriendSexEnum()
        {
            Name = "Sex";
            AddValue("female", "女", 0);
            AddValue("male", "男", 1);
        }
    }
}
