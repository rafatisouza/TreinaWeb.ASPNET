using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinaWeb.ASPNET.MVC.Models;

namespace TreinaWeb.ASPNET.MVC.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();  
        }

        //[HttpPost]
        //public  ActionResult Index(FormCollection formCollection)
        //{
        //    string nome = formCollection["nome"];
        //    ViewBag.menssagem = nome;
        //    return View("Saudacao");
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "Ativo")] Pessoa pessoa)
        {
            //ViewBag.menssagem = pessoa.Nome;
            pessoa.Ativo = true;
            if (ModelState.IsValid)
            {
             return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa);
            }
            
        }
    }
}