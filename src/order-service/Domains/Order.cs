using System;
using System.Collections;
using System.Collections.Generic;

namespace order_service.Domains
{
    public class Order : IEntity
    {
        public Guid Id { get; }
        private const int MaxOrderItemsSize = 20;
        public readonly List<OrderItem> OrderItems;

        public Order(List<OrderItem> orderItems)
        {
            Id = Guid.NewGuid();
            this.OrderItems = orderItems;
        }

        public static Order CreateOrder(List<OrderItem> orderItems)
        {
            if (IsOverOrderItemsSize(orderItems)) return null;
            
            foreach (var orderItem in orderItems)
            {
//                StorageList.ReduceQuantity(orderItem.GoodsId, orderItem.Quantity);
            }
            
            return  new Order(orderItems);
        }

        private static bool IsOverOrderItemsSize(ICollection items)
        {
            return items.Count > MaxOrderItemsSize;
        }
    }

    public interface IEntity
    {
        Guid Id { get; }
    }
}