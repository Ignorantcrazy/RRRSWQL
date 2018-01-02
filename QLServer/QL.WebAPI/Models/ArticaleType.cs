using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class ArticaleType :ObjectGraphType<Articale>
    {
        public ArticaleType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.UserId);
            Field(x => x.UserName);
            Field(x => x.Content);
            Field(x => x.Classification);
            Field(x => x.ClassificationId);
        }
    }
}
