using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMVCOdev.Controllers
{
    public class TerritoriesController : Controller
    {
        // GET: Territories
        public ActionResult Index()
        {
            return View();
        }
    }
}