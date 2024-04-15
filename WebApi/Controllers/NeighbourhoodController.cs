using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class NeighbourhoodController : BaseController<Neighbourhood, INeighbourhoodService>
    {
        public NeighbourhoodController(INeighbourhoodService baseService) : base(baseService)
        {
        }
    }
}
