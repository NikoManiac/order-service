using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using order_service.Applications;
using orderService.Domains;

namespace order_service.Interfaces
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISession session;
        private readonly IOrderApplicationService _applicationService;
        public OrderController(ISession session, IOrderApplicationService applicationService)
        {
            this.session = session;
            _applicationService = applicationService;
        }

        // GET api/health?check=all
        [HttpGet]
        public ActionResult<string> Get(string check = "all")
        {
            session.Query<TestObject>().ToList();
            return "Order Service is OK";
        }

        [HttpPost]
        public ActionResult<string> Post(List<OrderDto> orders)
        {
            _applicationService.CreateOrder(orders);
            return "";
        }

        // GET api/values
        /*[HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }*/

        // POST api/values
/*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
*/

        // PUT api/values/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        // DELETE api/values/5
        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }

    public abstract class OrderDto
    {
        public long Quantity { get; set; }
        public Guid ProductionId { get; set; }
    }
}