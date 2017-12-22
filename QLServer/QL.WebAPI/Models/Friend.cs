using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public int DroidId { get; set; }
        public string DroidName { get; set; }
    }
}
