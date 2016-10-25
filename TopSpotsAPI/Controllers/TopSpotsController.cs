using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : Controller
    {
        // GET: TopSpots
        public ActionResult Index()
        {
            return View();
        }
    }
}