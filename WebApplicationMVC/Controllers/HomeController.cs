using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC.ModelsViewData;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Certificados()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}