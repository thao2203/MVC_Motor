using MVC_Motor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Motor.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSanPham
        ClassEX a = new ClassEX();

        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult getlsp()
        {
            return Json(a.getlsp(), JsonRequestBehavior.AllowGet);
        }

    }
}