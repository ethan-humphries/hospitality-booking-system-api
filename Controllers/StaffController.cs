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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService staffService;

        public StaffController(IStaffService staffService)
        {
            this.staffService = staffService;
        }

        [HttpGet("{accountId}")]
        public IActionResult GetStaffByAccountId(string accountId)
        {
            var result = "";
            return Ok(result);
        }

        // POST api/bookings
        [HttpPost("{accountId}")]
        public IActionResult NewStaff(string accountId /* [FromBody] Staff staff */)
        {
            var result = "";
            return Ok(result);
        }

        // PUT api/bookings/5
        [HttpPut("{accountId}")]
        public void UpdateStaff(string accountId /* [FromBody] Staff staff */)
        {

        }

        // DELETE api/bookings/5
        [HttpDelete("{accountId}/delete/{customerId}")]
        public void DeleteStaff(string accountId, int staffId)
        {

        }
    }
}