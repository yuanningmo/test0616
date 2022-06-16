using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web0616410903864.Controllers
{
   
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult About()
        {
            return View();
        }

        public ActionResult index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult index(int number)
        {
            
            if (number == 1)
            {
                ViewBag.Message = "星期一";
            }
            else if (number == 2)
            {
                ViewBag.Message = "星期二";
            }
            else if (number == 3)
            {
                ViewBag.Message = "星期三";
            }
            else if (number == 4)
            {
                ViewBag.Message = "星期四";
            }
            else if (number == 5)
            {
                ViewBag.Message = "星期五";
            }
            else if (number == 6)
            {
                ViewBag.Message = "星期六";
            }
            else if (number == 7)
            {
                ViewBag.Message = "星期日";
            }
            else
            {
                ViewBag.Message = "請輸入1~7";
            }
            
            return View();
        }
    }

        
        
        
}