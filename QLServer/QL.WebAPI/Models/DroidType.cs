using AutoMapper;
using GraphQL.Types;
using QL.Core.Data;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType(IFriendRepository friendRepository,IMapper mapper)
        {
            Field(x => x.Id).Description("the id of the droid");
            Field(x => x.Name, nullable: true).Description("the name of the droid");
            Field<ListGraphType<FriendType>>(
                "friends",
                resolve:context =>
                {
                    var friends = friendRepository.GetFriendsByDroidId(context.Source.Id, "Droid").Result ;
                    var mapped = mapper.Map<List<Friend>>(friends);
                    return mapped;
                });
        }
    }
}
