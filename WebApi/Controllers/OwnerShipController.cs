using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class OwnerShipController : BaseController<OwnerShip, IOwnerShipService>
    {
        public OwnerShipController(IOwnerShipService baseService) : base(baseService)
        {
        }
    }
}
