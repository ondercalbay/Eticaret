using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Kategori;
using Eticaret.Dto.Slider;
using Eticaret.Dto.Urun;
using Eticaret.Entity;
using Eticaret.IL;
using Eticaret.WebUI.Helpers;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IKategoriManager _kategoriManager = new KategoriManager(UserHelper.Kullanici, new EfKategoriDal());
        IUrunManager _UrunManager = new UrunManager(UserHelper.Kullanici, new EfUrunDal(), new EfKategoriDal(), new EfResimDal());
        ISayfaManager _SayfaManager = new SayfaManager(UserHelper.Kullanici, new EfSayfaDal());
        ISliderManager _SliderManager = new SliderManager(UserHelper.Kullanici, new EfSliderDal(), new EfResimDal());
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View(_SayfaManager.Get(EnuSayfaTipleri.Iletisim));
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
            List<SliderListDto> slider = _SliderManager.GetSlider();
            return PartialView("_Slider", slider);
        }

        [ChildActionOnly]
        public PartialViewResult _UrunListe(EnuUrunListeTipi UrunListeTipi)
        {
            List<UrunVitrinDto> vitrin = _UrunManager.GetUrunListe(UrunListeTipi);
            return PartialView("_UrunListe", vitrin);
        }




    }
}