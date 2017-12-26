using System.Collections.Generic;

namespace QL.WebAPI.Models
{
    public class Droid
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Friend> Friends { get; set; }
    }
}
