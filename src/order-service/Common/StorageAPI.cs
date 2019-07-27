using System.Collections.Generic;
using System.Net.Http;
using NHibernate.Criterion;
using order_service.Interfaces;

namespace order_service.Common
{
    public class StorageAPI
    {
        private HttpClient _httpClient = new HttpClient();
 
        public void ReduceStorage(List<OrderDto> orderDtos)
        {
            _httpClient.PutAsync("api/storage", new MultipartContent(orderDtos.ToString()));
        }
    }
}