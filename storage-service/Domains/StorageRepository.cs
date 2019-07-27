using System;
using System.Collections.Generic;

namespace storage_service.Domains
{
    public class StorageRepository : IStorageRepository
    {
        public void BatchSave(List<Storage> storageList)
        {
            throw new NotImplementedException();
        }

        public Storage Find(Guid productionId)
        {
            throw new NotImplementedException();
        }

        public List<Storage> BatchFind(List<Guid> productionIds)
        {
            throw new NotImplementedException();
        }
    }
}