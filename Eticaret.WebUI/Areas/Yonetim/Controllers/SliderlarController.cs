using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Resim;
using Eticaret.Dto.Slider;
using Eticaret.Entity;
using Eticaret.IL;
using Eticaret.WebUI.Helpers;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.WebUI.Areas.Yonetim.Controllers
{
    [AuthorizeUserAccessLevel(UserRole = "admin sistem")]
    public class SliderlarController : Controller
    {
        ISliderManager _manager = new SliderManager(UserHelper.Kullanici, new EfSliderDal(), new EfResimDal());
        // GET: Yonetim/Sliderlar
        public ActionResult Index()
        {
            return View(_manager.Get(new Slider { Aktif = true }));
        }

        public ActionResult Edit(int? id)
        {
            SliderEditDto editDto;
            if (id == null)
            {
                editDto = new SliderEditDto();
                editDto.Resim = new ResimEditDto();
            }
            else
            {
                editDto = _manager.Get(Convert.ToInt32(id));
            }
            return View(editDto);
        }

        // POST: Sliderlar/Edit/5
        [HttpPost]
        public ActionResult Edit(SliderEditDto editDto, HttpPostedFileBase file)
        {
            ViewBag.Message = "Sliderlar";

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

                editDto.Resim = new ResimEditDto();
                editDto.Resim.ElementTipi = EnuElementler.Slider;
                editDto.Resim.ResimYolu = yer + "/" + dosyaAdi;
            }

            if (editDto.Id == 0)
            {
                _manager.Add(editDto);
            }
            else
            {
                _manager.Update(editDto);
            }
            return RedirectToAction("");

        }

        public ActionResult Delete(int id)
        {
            _manager.Delete(id);
            return RedirectToAction("");
        }
    }
}