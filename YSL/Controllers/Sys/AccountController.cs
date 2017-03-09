using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YSL.Controllers.Sys
{
    [Route("Sys/[controller]")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var result = new JsonResult("{'ok':true}");
            return result;
        }
    }
}