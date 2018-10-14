using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Firma;
using Eticaret.IL;
using Eticaret.WebUI.Helpers;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.WebUI.Areas.Yonetim.Controllers
{
    public class FirmaController : Controller
    {
        IFirmaManager _manager = new FirmaManager(UserHelper.Kullanici, new EfFirmaDal());
        // GET: Firma
        public ActionResult Index()
        {
            return View(_manager.Get(1));
        }

        public ActionResult Edit(int id)
        {
            return View(_manager.Get(id));
        }


        // POST: Firmalar/Index
        [HttpPost]
        public ActionResult Index(FirmaEditDto editDto, HttpPostedFileBase file)
        {            
            if (file != null)
            {
                //string pic = Path.GetFileName(file.FileName);
                string yer = string.Format("/images/{0}/{1}", DateTime.Now.Year, DateTime.Now.Month);
                string path = Server.MapPath(yer);
                // file is uploaded
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                path = Path.Combine(path, dosyaAdi);
                file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }


                editDto.LogoUrl = yer + "/" + dosyaAdi;
            }


            _manager.Update(editDto);
            FirmaHelper.Firma = editDto;
            return RedirectToAction("");

        }
    }
}