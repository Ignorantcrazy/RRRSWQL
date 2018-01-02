using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class Classification : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
