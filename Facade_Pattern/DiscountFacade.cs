using Facade_Pattern.Implementation;

namespace Facade_Pattern
{
    public class DiscountFacade: IDiscountFacade
    {
        private readonly IDateTimeService _datetimeservice;
        private readonly IDiscountBaseService _discountBaseService;
        private readonly IOrderService _orderService;

        public DiscountFacade(IDateTimeService datetimeservice,
            IDiscountBaseService discountBaseService,
            IOrderService orderService)
        {
            _datetimeservice = datetimeservice;
            _discountBaseService= discountBaseService;
            _orderService = orderService;
        }

        public decimal CalculateDiscount(int customerId)
        {
            var discount = _discountBaseService.GetBaseDiscount();
            if (_orderService.NumberOfPreviousOrders(customerId) > 10)
                discount = 50;
            if (_datetimeservice.isDemandSurgePeriod())
                discount= 0;
            return discount;
        }
    }
}
