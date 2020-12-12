using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
         {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUsuario(string email, string senha)
        {

            return Redirect(Url.Action("Index", "Home"));
        }

    }
}