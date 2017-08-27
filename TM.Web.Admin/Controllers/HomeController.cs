using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace TM.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult WelCome()
        {
            ViewBag.Title = "天马电商";
            return View();
        }


        [HttpGet]
        public ActionResult Test()
        {
            JsonResult firstResult = new JsonResult();
            firstResult.Data = new { a1 = "1", a2 = "3" };
            firstResult.ContentType = "text/html";
            firstResult.ContentEncoding = Encoding.UTF8;
            firstResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return firstResult;
        }
    }
}