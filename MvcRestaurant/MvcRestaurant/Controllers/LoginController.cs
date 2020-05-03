using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRestaurant.Models.Entity;
using System.Web.Security;

namespace MvcRestaurant.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DBRESTAURANTEntities db = new DBRESTAURANTEntities();
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(TBLUYELER p)
        {
            var bilgiler = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAIL, false);
                return RedirectToAction("Index", "Panelim");
            }
            else
            {
                return View();
            }
        }

    }
}