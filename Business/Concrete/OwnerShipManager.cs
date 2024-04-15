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
            _ownerShipDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(OwnerShip t)
        {
            _ownerShipDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<OwnerShip>> GetAll()
        {
            return new SuccessDataResult<List<OwnerShip>>(_ownerShipDal.GetAll());
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
