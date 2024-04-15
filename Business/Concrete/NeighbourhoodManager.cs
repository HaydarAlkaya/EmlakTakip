using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NeighbourhoodManager : INeighbourhoodService
    {
        private readonly INeighbourhoodDal _neighbourhoodDal;

        public NeighbourhoodManager(INeighbourhoodDal neighbourhoodDal)
        {
            _neighbourhoodDal = neighbourhoodDal;
        }

        public IResult Add(Neighbourhood t)
        {
            _neighbourhoodDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(Neighbourhood t)
        {
            _neighbourhoodDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<Neighbourhood>> GetAll()
        {
            return new SuccessDataResult<List<Neighbourhood>>(_neighbourhoodDal.GetAll());
        }

        public IDataResult<Neighbourhood> GetById(int id)
        {
            return new SuccessDataResult<Neighbourhood>(_neighbourhoodDal.Get(n => n.Id == id));
        }

        public IResult Update(Neighbourhood t)
        {
            _neighbourhoodDal.Update(t);
            return new SuccessResult();
        }
    }
}
