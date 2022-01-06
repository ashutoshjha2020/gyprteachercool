using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teachercooladmin.Controllers
{
    public class courseController : Controller
    {
        // GET: course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addcourse()
        {
            return View();
        }
    }
}