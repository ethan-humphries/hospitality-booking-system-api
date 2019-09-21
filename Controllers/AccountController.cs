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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost]
        public IActionResult CreateAccount([FromBody] Account account)
        {
            try
            {
                var result =  accountService.CreateAccount(account);
                return Ok(result);
            } catch(Exception e)
            {
                return Ok(e.Message);
            }
        }

        //[HttpGet]
        //public IActionResult GetAccounts()
        //{
        //    var result = "";
        //    try
        //    {
        //        result = accountService.GetAccounts();
        //        return Ok(result);
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(e.Message);
        //    }
        //}

        [HttpPost("/deactivate")]
        public IActionResult DeactivateAccount([FromBody] Account account)
        {
            var result = accountService.DeactivateAccount(account);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateAccount([FromBody] Account account)
        {
            var result = accountService.UpdateAccount(account);
            return Ok(result);
        }

        [HttpPost("{email}/authorize/{password}")]
        public IActionResult Authorize(string email, string password)
        {
            var result = accountService.Authorize(email, password);
            return Ok(result);
        }
    }
}