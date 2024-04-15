using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class CityController : BaseController<City, ICityService>
    {
        public CityController(ICityService baseService) : base(baseService)
        {
        }
    }
}
