using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.BL;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DemoModel demo)
        {
            DemoBL b = new DemoBL();
            List<DemoModel> a = b.DemoBuisness(demo);
            return View("~/Views/Demo/Index.cshtml", a);
        }
    }
}