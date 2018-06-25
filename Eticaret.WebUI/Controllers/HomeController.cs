using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Kategori;
using Eticaret.IL;
using Eticaret.WebUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult _Menu()
        {
            IKategoriManager _manager = new KategoriManager(UserHelper.Kullanici, new EfKategoriDal());

            List<KategoriMenuDto> menu = _manager.GetMenu(new KategoriMenuDto() { Id = -1 });
            return PartialView("_Menu", menu);
        }

        [ChildActionOnly]
        public PartialViewResult _Slider()
        {
            IKategoriManager _manager = new KategoriManager(UserHelper.Kullanici, new EfKategoriDal());

            List<KategoriMenuDto> menu = _manager.GetMenu(new KategoriMenuDto() { Id = -1 });
            return PartialView("_Slider", menu);
        }
    }
}