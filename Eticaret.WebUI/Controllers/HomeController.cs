using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Kategori;
using Eticaret.Dto.Urun;
using Eticaret.Entity;
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
        IKategoriManager _kategoriManager = new KategoriManager(UserHelper.Kullanici, new EfKategoriDal());
        IUrunManager _UrunManager = new UrunManager(UserHelper.Kullanici, new EfUrunDal(), new EfKategoriDal(), new EfResimDal());
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult _Menu()
        {
            

            List<KategoriMenuDto> menu = _kategoriManager.GetMenu(new KategoriMenuDto() { Id = -1 });
            return PartialView("_Menu", menu);
        }

        [ChildActionOnly]
        public PartialViewResult _Slider()
        {
            List<KategoriMenuDto> menu = _kategoriManager.GetMenu(new KategoriMenuDto() { Id = -1 });
            return PartialView("_Slider", menu);
        }

        [ChildActionOnly]
        public PartialViewResult _UrunListe(EnuUrunListeTipi UrunListeTipi)
        {
            List<UrunVitrinDto> vitrin = _UrunManager.GetUrunListe(UrunListeTipi);
            return PartialView("_UrunListe", vitrin);
        }


    }
}