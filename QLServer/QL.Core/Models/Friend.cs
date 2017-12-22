using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.Core.Models
{
    public class Friend : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }

        public Droid Droid { get; set; }

        //public ICollection<Droid> Droids { get; set; }
    }
}
