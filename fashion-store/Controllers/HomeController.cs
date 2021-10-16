using fashion_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fashion_store.Controllers
{
    public class HomeController : Controller
    {
        DBstore db = new DBstore();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
