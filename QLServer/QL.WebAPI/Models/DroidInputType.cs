using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class DroidInputType : InputObjectGraphType
    {
        public DroidInputType()
        {
            Name = "DroidInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}
