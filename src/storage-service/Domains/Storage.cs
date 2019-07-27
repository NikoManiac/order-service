using System;
using System.Collections.Generic;

namespace storage_service.Domains
{
    public class Storage
    {
        public Guid GoodsId { get; set; }
        public long Quantity { get; set; }
        
        public Storage(Guid goodsId, long quantity)
        {
            GoodsId = goodsId;
            Quantity = quantity;
        }

    }

    public static class StorageList
    {
        public static List<Storage> list;

        public static void CreateStorage(List<Storage> storages)
        {
            list = storages;
        }

        public static void ReduceQuantity(Guid goodsId, long quantity)
        {
            
            list.Find(x => x.GoodsId == goodsId).Quantity -= quantity;
        }
    }
}