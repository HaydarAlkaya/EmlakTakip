using Core.Entities;

namespace Entities.Concrete
{
    public class Neighbourhood : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
