using _16_TranThanhHau_Buoi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi1.Controllers
{
    public class Bai3_DNController : Controller
    {
        //
        // GET: /Bai3_DN/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap([Bind(Include = "UserName, Password")]User user)
        {
            if ("yennh".Equals(user.UserName) && "123456".Equals(user.Password))
            {
                Session["user"] = new User() { login = user.UserName, UserName = "Trần Thanh Hậu" };
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(string UserName, string Password, string RetypePassword)
        {
            if (UserName.Length >= 5 && Password.Length >= 6 && RetypePassword == Password)
                return RedirectToAction("DangNhap", "Bai3_DN");
            return View();
        }
    }
}
