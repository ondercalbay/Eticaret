using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.WebUI.Areas.Yonetim.Controllers
{
    public class HomeController : Controller
    {
        // GET: Yonetim/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}