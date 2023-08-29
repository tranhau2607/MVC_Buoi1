using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi1.Controllers
{
    public class HomeLoginController : Controller
    {
        //
        // GET: /HomeLogin/

        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "LoginHome");
            }
            return View();
        }

    }
}
