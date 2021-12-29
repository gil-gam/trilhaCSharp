using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01_ApresentacaoMVC.Models;


namespace Lab01_ApresentacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            @ViewBag.Agora = "Hello MVC! " + DateTime.Now;
            return View();
        }


        public ActionResult Filme()
        {
            Filme filme = new Filme()
            {
                Titulo = "Inglourious Bastards",
                Genero = "War",
                Assistido = true
            };
            return View(filme);
        }



    }

    
}


