using Core.Entities;

namespace Entities.Concrete
{
    public class ParselQuery : IEntity
    {
        public int Id { get; set; }
        public int OwnerShipId { get; set; }
        public byte[] Images { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
    }
}
