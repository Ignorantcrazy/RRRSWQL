using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class QLQueryModel
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public string Variables { get; set; }
    }
}
