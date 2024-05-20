using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OwnerShipManager : IOwnerShipService
    {
        private readonly IOwnerShipDal _ownerShipDal;

        public OwnerShipManager(IOwnerShipDal ownerShipDal)
        {
            _ownerShipDal = ownerShipDal;
        }

        public IResult Add(OwnerShip t)
        {
            _ownerShipDal.Add(new OwnerShip
            {
                Id = t.Id,
                Ada = t.Ada,
                BathCount = t.BathCount,
                BuildAge = t.BuildAge,
                CategoryId = t.CategoryId,
                CityId = t.CityId,
                Contents = t.Contents,
                CreatedDate = DateTime.Now,
                CustomerId = t.CustomerId,
                Exchange = t.Exchange,
                FloorLocation = t.FloorLocation,
                NeighbourhoodId = t.NeighbourhoodId,
                Parsel  = t.Parsel, 
                Price = t.Price,
                RentOrSale = t.RentOrSale,
                RoomCount = t.RoomCount,
                SquareFeet = t.SquareFeet,
                Status = true,
                Title = t.Title,
                TotalFloor = t.TotalFloor,
                TownId = t.TownId
            });
            return new SuccessResult();
        }

        public IResult Delete(OwnerShip t)
        {
            _ownerShipDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<OwnerShip>> GetAll()
        {
            var result = _ownerShipDal.GetAll()
                .OrderByDescending(e => e.Status == true)
                .OrderByDescending(e => e.CreatedDate);
            return new SuccessDataResult<List<OwnerShip>>(result.ToList());
        }

        public IDataResult<OwnerShip> GetById(int id)
        {
            return new SuccessDataResult<OwnerShip>(_ownerShipDal.Get(o => o.Id==id));
        }

        public IResult Update(OwnerShip t)
        {
            _ownerShipDal.Update(t);
            return new SuccessResult();
        }
    }
}
