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
        StoreMusicContext storeDB = new StoreMusicContext();

        public ActionResult Index()
        {
            //var albums = GetTopSellingAlbums(5);
            var albums = storeDB.Albums.ToList();
            return View(albums);
        }

       private List<Album> GetTopSellingAlbums(int count)
        {
            return storeDB.Albums
                    .OrderByDescending(a => a.OrderDetails.Count())
                    .Take(count)
                    .ToList();
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