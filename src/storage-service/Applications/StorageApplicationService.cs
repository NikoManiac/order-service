using System.Collections.Generic;
using System.Linq;
using storage_service.Domains;
using storage_service.Interface;

namespace storage_service.Applications
{
    public class StorageApplicationService : IStorageApplicationService
    {
        private readonly IStorageRepository _repository;

        public StorageApplicationService(IStorageRepository repository)
        {
            _repository = repository;
        }

        public void ReduceStorage(List<OrderDto> orderDtos)
        {
            var storageList = _repository.BatchFind(orderDtos.Select(x => x.ProductionId).ToList());            
            storageList.ForEach(x => x.Quantity -= orderDtos.Find(y => y.ProductionId == x.GoodsId).Quantity);
            _repository.BatchSave(storageList);
        }
    }
}