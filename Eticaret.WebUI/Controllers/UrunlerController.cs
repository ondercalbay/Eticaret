﻿using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Urun;
using Eticaret.Entity;
using Eticaret.IL;
using Eticaret.WebUI.Helpers;
using System.Linq;
using System.Web.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class UrunlerController : Controller
    {
        IUrunManager _UrunManager = new UrunManager(UserHelper.Kullanici, new EfUrunDal(), new EfKategoriDal(), new EfResimDal());
        IKategoriManager _KategoriManager = new KategoriManager(UserHelper.Kullanici, new EfKategoriDal());
        IResimManager _ResimManager = new ResimManager(UserHelper.Kullanici, new EfResimDal());

        // GET: Urunlar
        public ActionResult Index(string Kategori)
        {
            ViewBag.Title = _KategoriManager.Get(new Kategori() { Url = Kategori }).FirstOrDefault().Adi;
            return View(_UrunManager.Get(Kategori));
        }
        public ActionResult Detay(int id)
        {
            UrunDetailDto editDto = _UrunManager.GetDetay(id);


            return View(editDto);
        }


        //public ActionResult Edit(int? id)
        //{
        //    UrunEditDto editDto;
        //    if (id == null)
        //    {
        //        editDto = new UrunEditDto();
        //    }
        //    else
        //    {
        //        editDto = _UrunManager.Get(Convert.ToInt32(id));
        //        ViewBag.Resimler = _ResimManager.Get(new Resim { ElementTipi = EnuElementler.Urun, ElementId = Convert.ToInt32(id) });
        //    }

        //    IEnumerable<KategoriListDto> kategoriler = _KategoriManager.Get(new Kategori());
        //    List<SelectListItem> selectkategoriler = new SelectList(kategoriler, "Id", "Adi", editDto.KategoriId).ToList();

        //    selectkategoriler.Insert(0, new SelectListItem() { Value = "", Text = "Seçiniz" });
        //    ViewBag.KategoriId = selectkategoriler;


        //    return View(editDto);
        //}

        //// POST: Urunlar/Edit/5
        //[HttpPost]
        //public ActionResult Edit(UrunEditDto editDto)
        //{
        //    ViewBag.Message = "Urunlar";
        //    if (editDto.Id == 0)
        //    {
        //        _UrunManager.Add(editDto);
        //    }
        //    else
        //    {
        //        _UrunManager.Update(editDto);
        //    }
        //    return RedirectToAction("");

        //}

        //public ActionResult Resimler(int id)
        //{
        //    Resim filter = new Resim();
        //    filter.ElementTipi = EnuElementler.Urun;
        //    filter.ElementId = id;
        //    UrunResimEkleDto model = new UrunResimEkleDto();
        //    model.Id = id;
        //    model.Resimler = _ResimManager.Get(filter);
        //    return View(model);
        //}

        //public ActionResult FileUpload(HttpPostedFileBase file, int id)
        //{
        //    if (file != null)
        //    {
        //        //string pic = Path.GetFileName(file.FileName);
        //        string yer = String.Format("/images/{0}/{1}", DateTime.Now.Year, DateTime.Now.Month);
        //        string path = Server.MapPath(yer);
        //        // file is uploaded
        //        if (!Directory.Exists(path))
        //        {
        //            Directory.CreateDirectory(path);
        //        }
        //        string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        //        path = Path.Combine(path, dosyaAdi);
        //        file.SaveAs(path);

        //        // save the image path path to the database or you can send image 
        //        // directly to database
        //        // in-case if you want to store byte[] ie. for DB
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            file.InputStream.CopyTo(ms);
        //            byte[] array = ms.GetBuffer();
        //        }

        //        ResimEditDto resim = new ResimEditDto();
        //        resim.ElementId = id;
        //        resim.ElementTipi = EnuElementler.Urun;
        //        resim.ResimYolu = yer + "/" + dosyaAdi;
        //        _ResimManager.Add(resim);
        //    }
        //    // after successfully uploading redirect the user
        //    return RedirectToAction("Resimler", "Urunler", new { Id = id });
        //}

        //public ActionResult FileDelete(int id, int UrunId)
        //{
        //    _ResimManager.Delete(id);

        //    return RedirectToAction("Resimler", "Urunler", new { Id = UrunId });
        //}

        //// GET: Urunlar/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    _UrunManager.Delete(id);
        //    return RedirectToAction("");
        //}

    }
}
