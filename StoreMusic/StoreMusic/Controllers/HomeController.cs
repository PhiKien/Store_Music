using StoreMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreMusic.Controllers
{
    public class HomeController : Controller
    {
        private StoreMusicContext storeDB;

        public HomeController()
        {
            storeDB = new StoreMusicContext();
        }
        public ActionResult Index()
        {
            var albums = storeDB.Albums.ToList();
            return View(albums);
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