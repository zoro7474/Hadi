using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcRestaurant.Controllers
{
    public class YemekController : Controller
    {
        // GET: Yemek
        
        public ActionResult Index()
        {
            return View();
        }
    }
}