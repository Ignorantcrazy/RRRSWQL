using GraphQL.Types;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Field(x => x.Id).Description("the id of the droid");
            Field(x => x.Name, nullable: true).Description("the name of the droid");
        }
    }
}
