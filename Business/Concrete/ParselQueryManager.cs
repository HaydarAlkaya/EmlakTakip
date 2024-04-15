using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ParselQueryManager : IParselQueryService
    {
        private readonly IParselQueryDal _parselQueryDal;

        public ParselQueryManager(IParselQueryDal parselQueryDal)
        {
            _parselQueryDal = parselQueryDal;
        }

        public IResult Add(ParselQuery t)
        {
            _parselQueryDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(ParselQuery t)
        {
            _parselQueryDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<ParselQuery>> GetAll()
        {
            return new SuccessDataResult<List<ParselQuery>>(_parselQueryDal.GetAll());
        }

        public IDataResult<ParselQuery> GetById(int id)
        {
            return new SuccessDataResult<ParselQuery>(_parselQueryDal.Get(p => p.Id == id));
        }

        public IResult Update(ParselQuery t)
        {
            _parselQueryDal.Update(t);
            return new SuccessResult();
        }
    }
}
