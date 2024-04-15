using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City t)
        {
            _cityDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(City t)
        {
            _cityDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IDataResult<City> GetById(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.Id == id));
        }

        public IResult Update(City t)
        {
            _cityDal.Update(t);
            return new SuccessResult();
        }
    }
}
