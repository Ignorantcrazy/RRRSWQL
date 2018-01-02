using QL.Core.Data;

namespace QL.Core.Models
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NickName { get; set; }
        public string Pwd { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
    }
}