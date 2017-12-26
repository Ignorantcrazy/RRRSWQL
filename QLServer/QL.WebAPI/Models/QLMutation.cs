using AutoMapper;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class QLMutation : ObjectGraphType<object>
    {
        public QLMutation(Core.Data.IDroidRepository droidRepository, Core.Data.IFriendRepository friendRepository, IMapper mapper)
        {
            Name = "Mutation";

            Field<DroidType>(
                "createDroid",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<DroidInputType>> { Name = "droid" }
                    ),
                resolve: context =>
                 {
                     var droid = context.GetArgument<Droid>("droid");
                     var mapped = mapper.Map<Core.Models.Droid>(droid);
                     var droidadd = droidRepository.Add(mapped);
                     droidRepository.SaveChangesAsync();
                     return mapper.Map<Droid>(droidadd);
                 });

            Field<ListGraphType<DroidType>>(
                "createDroids",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ListGraphType<DroidInputType>>> { Name = "droids" }
                    ),
                resolve: context =>
                {
                    var droids = context.GetArgument<List<Droid>>("droids");
                    var mapped = mapper.Map<List<Core.Models.Droid>>(droids);
                    var droidsadd = droidRepository.AddRange(mapped);
                    droidRepository.SaveChangesAsync();
                    return mapper.Map<List<Droid>>(droidsadd);
                });
        }
    }
}
