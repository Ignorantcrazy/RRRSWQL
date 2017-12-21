using GraphQL.Types;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class QLQuery : ObjectGraphType
    {
        public QLQuery() { }
        public QLQuery(Core.Data.IDroidRepository droidRepository,Core.Data.IFriendRepository friendRepository)
        {
            Field<DroidType>(
                "hero",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id" }
                    ),
                resolve: context => 
                {
                    var id = context.GetArgument<int>("id");
                    return droidRepository.Get(id).Result;
                });

            Field<ListGraphType<DroidType>>(
                "heros",
                resolve : context => droidRepository.GetAll().Result
                );

            Field<FriendType>(
                "friend",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name ="id" }
                    ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                   
                        return friendRepository.Get(id).Result;
                });

            Field<ListGraphType<FriendType>>(
                "friends",
                arguments: new QueryArguments(
                    new QueryArgument<FriendSexEnum> { Name = "sex" }
                    ),
                resolve: context =>
                {
                    var sex = context.GetArgument<FriendSex?>("sex");
                    if (sex.HasValue)
                    {
                        return friendRepository.GetFriendBySex((int)sex.Value).Result;
                    }
                    return friendRepository.GetAll().Result;
                });
        }
    }
}
