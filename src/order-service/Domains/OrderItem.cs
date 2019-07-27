using System;

namespace order_service.Domains
{
    public class OrderItem
    {
        public Guid GoodsId { get; set; }
        public long Quantity { get; set; }
        
        public OrderItem(Guid goodsId, long quantity)
        {
            GoodsId = goodsId;
            Quantity = quantity;
        }
    }
}