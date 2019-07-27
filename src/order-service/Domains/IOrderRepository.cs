namespace order_service.Domains
{
    public interface IOrderRepository
    {
        Order Save(Order order);
        Order Find();
    }

    public class OrderRepository : IOrderRepository
    {
        public Order Save(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Order Find()
        {
            throw new System.NotImplementedException();
        }
    }
}