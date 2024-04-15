using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category t)
        {
            _categoryDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(Category t)
        {
            _categoryDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(u => u.Id == id));
        }

        public IResult Update(Category t)
        {
            _categoryDal.Update(t);
            return new SuccessResult();
        }
    }
}
