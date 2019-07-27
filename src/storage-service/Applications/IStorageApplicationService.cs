using System.Collections.Generic;
using storage_service.Interface;

namespace storage_service.Applications
{
    public interface IStorageApplicationService
    {
        void ReduceStorage(List<OrderDto> orderDtos);
    }
}