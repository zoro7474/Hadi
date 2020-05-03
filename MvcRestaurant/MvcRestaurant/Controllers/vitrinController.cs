using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRestaurant.Controllers
{
    public class vitrinController : Controller
    {
        // GET: vitrin
        public ActionResult Index()
        {
            return View();
        }
    }
}