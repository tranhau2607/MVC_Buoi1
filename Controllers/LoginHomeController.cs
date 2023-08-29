using _16_TranThanhHau_Buoi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi1.Controllers
{
    public class LoginHomeController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "UserName, Password")]User user)
        {
            if ("yennh".Equals(user.UserName) && "123456".Equals(user.Password))
            {
                Session["user"] = new User() { login = user.UserName, UserName = "Trần Thanh Hậu" };
            }
            return RedirectToAction("Index", "HomeLogin");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string UserName, string Password, string RetypePassword)
        {
            if (UserName.Length >= 5 && Password.Length >= 6 && RetypePassword == Password)
                return RedirectToAction("Login", "LoginHome");
            return View();
        }

    }
}
