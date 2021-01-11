using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mist.Models;
using Mist.DB;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting;

namespace Mist.Controllers
{
    public class HomeController : Controller
    {
        private SportsmanContext db = new SportsmanContext();
        public ActionResult Index()
        {
            IEnumerable<Sportsman> sportsmans = db.Sportsmans;
            ViewBag.Sportsmans = sportsmans;
            return View();
        }
        [HttpGet]
        public ActionResult Res(int id)
        {
            var Details = (from sportsmans in db.Sportsmans
                           where sportsmans.ID == id
                           select sportsmans).First();
            return View(Details);
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