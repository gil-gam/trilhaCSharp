using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
using MvcMovie.ViewModels;
using Microsoft.AspNet.Identity;

namespace MvcMovie.Controllers
{
    public class LogController : Controller
    {

        private MovieDBContext logDb = new MovieDBContext();

        protected override void Dispose(bool disposing)
        {
            logDb.Dispose();
            base.Dispose(disposing);
        }
        

        private MovieDBContext db = new MovieDBContext();

        // GET: Logs
        public ActionResult Index()
        {
            return View(db.Log.ToList());
        }

        // GET: Logs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Log log = db.Log.Find(id);
            if (log == null)
            {
                return HttpNotFound();
            }
            return View(log);
        }

        
        
        public ActionResult Logs()
        {
            var data = from Log in logDb.Log
                           //group movie by movie.Id
                           //into dateGroup                             
                       select new LogInfo()
                       {
                           Id = Log.Id,
                           Data = Log.Data,
                           Usuario = User.Identity.GetUserName(),
                           Operacao = Log.Operacao
                       };
            //return View(data.OrderByDescending(g => g.Data).ToList());
            return View();

        }

    }
}
