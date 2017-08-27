using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TM.Web.Admin.Controllers
{
    public class MyAjaxController : Controller
    {
        // GET: MyAjax
        [HttpPost]
        public ActionResult Calc(MyNum myNum)
        {
            int sum = myNum.Number1 + myNum. Number2; 
            return Content(sum.ToString());
        }


        public ActionResult Ajax()
        {
            return View();
        }
    }

    public class MyNum
    {
       public int Number1 { get; set; }
       public int Number2 { get; set; }
    }
}