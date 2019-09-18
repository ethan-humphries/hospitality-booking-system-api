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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService staffService;

        public StaffController(IStaffService staffService)
        {
            this.staffService = staffService;
        }

        [HttpGet("{accountId}")]
        public IActionResult GetStaffByAccountId(int accountId)
        {
            try
            {
                var result = staffService.GetStaff(accountId);
                return Ok(result);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPost]
        public IActionResult NewStaff([FromBody] Staff staff)
        {
            try
            {
                var result = staffService.AddStaff(staff);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateStaff([FromBody] Staff staff)
        {
            try
            {
                var result = staffService.UpdateStaff(staff);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteStaff([FromBody] Staff staff)
        {
            try
            {
                var result = staffService.DeleteStaff(staff);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
    }
}