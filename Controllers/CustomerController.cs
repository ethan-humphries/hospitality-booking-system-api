using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBSApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HBSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("{accountId}")]
        public IActionResult GetCustomersByUserId(string accountId)
        {
            var result = "";
            return Ok(result);
        }

        // POST api/bookings
        [HttpPost("{accountId}")]
        public IActionResult NewCustomer(string accountId /* [FromBody] Customer customer */)
        {
            var result = "";
            return Ok(result);
        }

        // PUT api/bookings/5
        [HttpPut("{accountId}")]
        public void UpdateCustomer(string accountId /* [FromBody] Customer customer */)
        {

        }

        // DELETE api/bookings/5
        [HttpDelete("{accountId}/delete/{customerId}")]
        public void DeleteCustomer(string accountId, int customerId)
        {

        }
    }
}