using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;

namespace YSL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var id = Guid.NewGuid().ToString("N");
            //var obj = new hrm_department();
            //obj.id = Guid.NewGuid().ToString("N");
            //var db = YSLContextFactory.Create();
            //db.hrm_department.Add(obj);
            //db.SaveChanges();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
