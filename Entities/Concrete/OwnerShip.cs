using Core.Entities;

namespace Entities.Concrete
{
    public class OwnerShip : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public int NeighbourhoodId { get; set; }
        public string SquareFeet { get; set; }
        public string? RoomCount { get; set; }
        public string? BathCount { get; set;}
        public string? BuildAge { get; set; }
        public bool? RentOrSale { get; set; }
        public string? FloorLocation { get; set; }
        public string? TotalFloor { get; set;}
        public bool? Exchange { get; set; }
        public string? Ada { get; set; }
        public string? Parsel { get; set; }
        public string Price { get; set; }
        public int CustomerId { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
    }
}
