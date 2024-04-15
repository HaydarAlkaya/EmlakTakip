using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class CategoryController : BaseController<Category, ICategoryService>
    {
        public CategoryController(ICategoryService baseService) : base(baseService)
        {
        }
    }
}
