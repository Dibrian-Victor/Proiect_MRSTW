using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitPlaneLife.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();  
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Feature()
        {
            return View();
        }
        public ActionResult Class()
        {
            return View();
        }

    }
}
