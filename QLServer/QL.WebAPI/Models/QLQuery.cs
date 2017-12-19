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
        public QLQuery()
        {
            Field<DroidType>(
                "hero",
                resolve: context => new Droid {Id = 1,Name = "R2-D2" }
                );
        }
    }
}
