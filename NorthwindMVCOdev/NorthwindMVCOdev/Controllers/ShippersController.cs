using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMVCOdev.Controllers
{
    public class ShippersController : Controller
    {
        // GET: Shippers
        public ActionResult Index()
        {
            return View();
        }
    }
}