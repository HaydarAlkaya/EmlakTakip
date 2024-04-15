using Business.Abstract;
using Core.Entities;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class BaseManager<T> : IBaseService<T>
        where T : class, IEntity, new()
    {
        private readonly IBaseService<T> _baseService;

        public BaseManager(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        public IResult Add(T t)
        {
            _baseService.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(T t)
        {
            _baseService?.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<T>> GetAll()
        {
            var result = _baseService.GetAll();
            return new SuccessDataResult<List<T>>(result.Data);
        }

        public IDataResult<T> GetById(int id)
        {
            return new SuccessDataResult<T>(_baseService.GetById(id));
        }

        public IResult Update(T t)
        {
            _baseService.Update(t);
            return new SuccessResult();
        }
    }
}
