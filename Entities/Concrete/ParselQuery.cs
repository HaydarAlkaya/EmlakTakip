using Core.Entities;

namespace Entities.Concrete
{
    public class ParselQuery : IEntity
    {
        public int Id { get; set; }
        public int OwnerShipId { get; set; }
        public string Locations { get; set; }
    }
}
