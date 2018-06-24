using Eticaret.WebUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.WebUI.Areas.Yonetim.Controllers
{
    [AuthorizeUserAccessLevel(UserRole = "admin sistem")]
    public class HomeController : Controller
    {
        // GET: Yonetim/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}