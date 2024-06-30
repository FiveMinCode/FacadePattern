using Facade_Pattern.Model;
using Microsoft.AspNetCore.Mvc;

namespace Facade_Pattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountFacade _discountFacade;
        public DiscountController(IDiscountFacade discountFacade) {
            _discountFacade = discountFacade;
        }

        [HttpGet]
        public Discount GetDiscount(int customerId)
        {
            return new Discount { Amount = _discountFacade.CalculateDiscount(customerId) };
        }
    }
}