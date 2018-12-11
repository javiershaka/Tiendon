using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tiendon.Web.Models;

namespace Tiendon.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            pruebaConexion p = new pruebaConexion();
            
            return View(p);
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