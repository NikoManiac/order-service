using System;

namespace order_service.Domains.Goods
{
    public class Goods
    {
        public Guid Id = Guid.NewGuid();
        private string Name { get; set; }
        private float Price { get; set; }

        public Goods(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}