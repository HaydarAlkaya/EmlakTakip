using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class TownController : BaseController<Town, ITownService>
    {
        public TownController(ITownService baseService) : base(baseService)
        {
        }
    }
}
