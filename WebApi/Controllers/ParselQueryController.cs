using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class ParselQueryController : BaseController<ParselQuery, IParselQueryService>
    {
        public ParselQueryController(IParselQueryService baseService) : base(baseService)
        {
        }
    }
}
