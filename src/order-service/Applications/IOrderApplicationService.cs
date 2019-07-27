using System.Collections.Generic;
using order_service.Domains;
using order_service.Interfaces;

namespace order_service.Applications
{
    public interface IOrderApplicationService
    {
        Order CreateOrder(List<OrderDto> orderDto);
    }
}