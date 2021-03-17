using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurantly.Models;

namespace Restaurantly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ResturantlyDatabase db = new ResturantlyDatabase();
            db.OpenConnection();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}