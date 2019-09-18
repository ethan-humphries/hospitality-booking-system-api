using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBSApi.Models;
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
        public IActionResult GetCustomersByUserId(int accountId)
        {
            try
            {
                var result = customerService.GetCustomers(accountId);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPost]
        public IActionResult NewCustomer([FromBody] Customer customer)
        {
            try
            {
                var result = customerService.AddCustomer(customer);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            try
            {
                var result = customerService.UpdateCustomer(customer);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpDelete]
        public void DeleteCustomer([FromBody] Customer customer)
        {
            try
            {
                var result = customerService.UpdateCustomer(customer);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}