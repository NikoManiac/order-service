using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using storage_service.Applications;

namespace storage_service.Interface
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly IStorageApplicationService _storageApplicationService;

        public StorageController(IStorageApplicationService storageApplicationService)
        {
            _storageApplicationService = storageApplicationService;
        }

        [HttpPut]
        public ActionResult<string> Put(List<OrderDto> orderDtos)
        {
            _storageApplicationService.ReduceStorage(orderDtos);
            return "";
        }
    }


    public abstract class OrderDto
    {
        public long Quantity { get; set; }
        public Guid ProductionId { get; set; }
    }
}