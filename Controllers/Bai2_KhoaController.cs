using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi1.Controllers
{
    public class Bai2_KhoaController : Controller
    {
        //
        // GET: /Bai2_Khoa/

        public ActionResult Index()
        {
            Models.KhoaModels khoaCNTT = new Models.KhoaModels();
            khoaCNTT.Messager = "HUIT: HỌC TẬP - NĂNG ĐỘNG - SÁNG TẠO";
            return View(khoaCNTT);
        }

    }
}
