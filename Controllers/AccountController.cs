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
            var result = "";
            using (HBSContext context = new HBSContext()) {
                context.Account.Add(account);
                context.SaveChanges();
            }
            return Ok(result);
        }

        [HttpPost]
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