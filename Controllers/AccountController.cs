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
        public IActionResult CreateAccount([FromBody]Account account)
        {
            var result = "";
            using (HBSContext context = new HBSContext()) {
                context.Account.Add(account);
                context.SaveChanges();
            }
            return Ok(result);
        }

        [HttpPost("/deactivate")]
        public IActionResult DeactivateAccount(/* AccountModel */)
        {
            var result = "";
            return Ok(result);
        }

        [HttpPut("/update")]
        public IActionResult UpdateAccount(/* AccountModel */)
        {
            var result = "";
            return Ok(result);
        }

        [HttpPost("/authorize")]
        public IActionResult Authorize(/* AccountModel */)
        {
            var result = "";
            return Ok(result);
        }
    }
}