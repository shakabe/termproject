using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    //[Authorize (Roles = "admin,user")]
    public class HomeController : Controller
    {
        projectEntities4 obj = new projectEntities4();

       [Authorize(Roles="admin,user")]
        public ActionResult Index()
        {


            return View(obj.firstPages.ToList());

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult form()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


    }
}