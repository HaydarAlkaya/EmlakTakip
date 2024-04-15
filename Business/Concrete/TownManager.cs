using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TownManager : ITownService
    {
        private readonly ITownDal _townDal;

        public TownManager(ITownDal townDal)
        {
            _townDal = townDal;
        }

        public IResult Add(Town t)
        {
            _townDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(Town t)
        {
            _townDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<Town>> GetAll()
        {
            return new SuccessDataResult<List<Town>>(_townDal.GetAll());
        }

        public IDataResult<Town> GetById(int id)
        {
            return new SuccessDataResult<Town>(_townDal.Get(t => t.Id == id));
        }

        public IResult Update(Town t)
        {
            _townDal.Update(t);
            return new SuccessResult();
        }
    }
}
