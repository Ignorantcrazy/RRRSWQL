using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.Core.Models
{
    public class Droid : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Friend> Friends { get; set; }
    }
}
