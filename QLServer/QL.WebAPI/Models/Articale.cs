using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class Articale
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Classification { get; set; }
        public int ClassificationId { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
    }
}
