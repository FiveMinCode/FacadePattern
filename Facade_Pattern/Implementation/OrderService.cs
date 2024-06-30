namespace Facade_Pattern.Implementation
{
    public class OrderService: IOrderService
    {
        public int NumberOfPreviousOrders(int customerId)
        {
            if (customerId > 100)
            {
                return 50;
            }
            else
            {
                return 1;
            }
        }
    }
}
