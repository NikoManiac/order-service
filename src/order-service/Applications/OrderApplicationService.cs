
using System.Collections.Generic;
using System.Linq;
using order_service.Domains;
using order_service.Interfaces;

namespace order_service.Applications
{
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderRepository _repository;

        public OrderApplicationService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public Order CreateOrder(List<OrderDto> orderDto)
        {
            var orderItems = orderDto.Select(x => new OrderItem(x.ProductionId, x.Quantity)).ToList();
            var order = Order.CreateOrder(orderItems);
            if (order != null)
            {
                
            }
            _repository.Save(order);
            return order;
        }
    }
}