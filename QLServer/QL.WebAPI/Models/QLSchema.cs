using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class QLSchema : Schema
    {
        public QLSchema(Func<Type, GraphType> resolveType) : base(resolveType)
        {
            Query = (QLQuery)resolveType(typeof(QLQuery));
        }
    }
}
