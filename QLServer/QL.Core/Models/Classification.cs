using QL.Core.Data;

namespace QL.Core.Models
{
    public class Classification : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}