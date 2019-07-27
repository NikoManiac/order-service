using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace storage_service.Domains
{
    public interface IStorageRepository
    {
        void BatchSave(List<Storage> storageList);
        Storage Find(Guid productionId);
        List<Storage> BatchFind(List<Guid> productionIds);
    }
}