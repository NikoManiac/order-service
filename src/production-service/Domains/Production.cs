using System;
using System.Collections.Generic;

namespace production_service.Domains
{
    public class Produciton
    {
        public Guid GoodsId { get; set; }
        public long Quantity { get; set; }
        
        public Produciton(Guid goodsId, long quantity)
        {
            GoodsId = goodsId;
            Quantity = quantity;
        }

    }

    public static class StorageList
    {
        public static List<Produciton> list;

        public static void CreateStorage(List<Produciton> storages)
        {
            list = storages;
        }

        public static void ReduceQuantity(Guid goodsId, long quantity)
        {
            
            list.Find(x => x.GoodsId == goodsId).Quantity -= quantity;
        }
    }
}