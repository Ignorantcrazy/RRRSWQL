using QL.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.Core.Models
{
    public class Articale : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Classification Classification { get; set; }
        public User User { get; set; }
    }
}
