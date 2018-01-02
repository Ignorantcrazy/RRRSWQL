using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.Id);
            Field(x => x.Code);
            Field(x => x.NickName);
            Field(x => x.Pwd);
            Field(x => x.Gender);
            Field(x => x.Age);
        }
    }
}
