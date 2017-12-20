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
        public QLQuery(Core.Data.IDroidRepository droidRepository)
        {
            Field<DroidType>(
                "hero",
                //arguments: new QueryArguments(
                //    new QueryArgument<DroidType> {Name="Id", Description="id" }
                //    ),
                resolve: context => droidRepository.Get(1).Result
                );
        }
    }
}
