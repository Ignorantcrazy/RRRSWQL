using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class ClassificationType : ObjectGraphType<Classification>
    {
        public ClassificationType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}
