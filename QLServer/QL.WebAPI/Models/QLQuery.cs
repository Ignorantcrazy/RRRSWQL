using AutoMapper;
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
        public QLQuery(Core.Data.IDroidRepository droidRepository,Core.Data.IFriendRepository friendRepository,IMapper mapper)
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
                resolve : context =>
                {
                    var droid = droidRepository.GetAll();
                    var mapped = mapper.Map<List<Droid>>(droid);
                    return mapped;
                });

            Field<FriendType>(
                "friend",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name ="id" }
                    ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    var result = friendRepository.Get(id,include: "Droid").Result;
                    var mapped = mapper.Map<Friend>(result);
                    return mapped;
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
                        var sexfriends = friendRepository.GetFriendBySex((int)sex.Value,"Droid").Result;
                        var sexmapped = mapper.Map<List<Friend>>(sexfriends);
                        return sexmapped;
                    }
                    var friends = friendRepository.GetAll("Droid").Result;
                    var mapped = mapper.Map<List<Friend>>(friends);
                    return mapped;
                });
        }
    }
}
