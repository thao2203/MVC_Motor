using MVC_Motor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Motor.Controllers
{
    public class SanPhamController : Controller
    {
        ClassEX a = new ClassEX();

        // GET: SanPham
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SanPham()
        {
            return View();
        }
        public JsonResult getsp()
        {
            return Json(a.getsp(), JsonRequestBehavior.AllowGet); //convert sang json
        }
        public ActionResult LoaiSanPham()
        {
            return View();
        }

        public JsonResult getdanhmuccon(string mlsp)
        {
            return Json(a.getbylsp(mlsp), JsonRequestBehavior.AllowGet);
        }
    }
}