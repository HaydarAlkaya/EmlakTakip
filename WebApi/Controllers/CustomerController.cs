using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    public class CustomerController : BaseController<Customer, ICustomerService>
    {
        public CustomerController(ICustomerService baseService) : base(baseService)
        {
        }
    }
}
