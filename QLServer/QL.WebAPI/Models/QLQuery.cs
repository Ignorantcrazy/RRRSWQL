using AutoMapper;
using GraphQL.Types;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class QLQuery : ObjectGraphType<object>
    {
        public QLQuery() { }
        public QLQuery(Core.Data.IDroidRepository droidRepository,Core.Data.IFriendRepository friendRepository,
            Core.Data.IArticaleRepository articaleRepository,Core.Data.IClassificationRepository classificationRepository,
            Core.Data.IUserRepository userRepository,
            IMapper mapper)
        {
            Name = "Query";

            Field<ListGraphType<ArticaleType>>(
                "articles",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> {Name= "classificationId" },
                    new QueryArgument<IntGraphType> {Name= "userId" }
                    ),
                resolve: context => {
                    var classificationId = context.GetArgument<int?>("classificationId");
                    var userId = context.GetArgument<int?>("userId");
                    var articles = articaleRepository.GetAll(classificationId, userId,"Classification", "User").Result;
                    var mapped = mapper.Map<List<Articale>>(articles);
                    return mapped;
            });

            Field<ListGraphType<ClassificationType>>(
                "classifications",
                resolve:context => {
                    var classifications = classificationRepository.GetAll().Result;
                    var mapped = mapper.Map<List<Classification>>(classifications);
                    return mapped;
                });

            Field<UserType>(
                "user",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id"}
                    ),
                resolve: context => {
                    var id = context.GetArgument<int>("id");
                    var user = userRepository.Get(id).Result;
                    var mapped = mapper.Map<User>(user);
                    return mapped;
                 });

            Field<DroidType>(
                "hero",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id" }
                    ),
                resolve: context => 
                {
                    var id = context.GetArgument<int>("id");
                    var droid = droidRepository.Get(id).Result;
                    var mapped = mapper.Map<Droid>(droid);
                    return mapped;
                });

            Field<ListGraphType<DroidType>>(
                "heros",
                resolve : context =>
                {
                    var droids = droidRepository.GetAll().Result;
                    var mapped = mapper.Map<List<Droid>>(droids);
                    return mapped;
                    //var droidsview = new List<Droid>();
                    //foreach (var item in droids.Result)
                    //{
                    //    droidsview.Add()
                    //}
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
