using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.ModelsViewData;
using WebApplicationMVC.Service.Services;

namespace WebApplicationMVC.Controllers
{
    public class CadastroController : Controller
    {
        public CadastroService CadastroService { get; set; }

        public CadastroController()
        {
            CadastroService = new CadastroService();
        }


        // GET: Cadastro
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CadastroUsuario(string nome, string email, string confEmail, string senha, string confSenha)
        {
            try
            {
                CadastroService.SalvarUsuario(nome, email, confEmail, senha, confSenha);
                return Redirect(Url.Action("Index", "Login"));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

