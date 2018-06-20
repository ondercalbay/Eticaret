using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Sayfa;
using Eticaret.Entity;
using Eticaret.IL;
using Eticaret.WebUI.Helpers;
using System;
using System.Web.Mvc;

namespace Eticaret.WebUI.Areas.Yonetim.Controllers
{
    public class SayfalarController : Controller
    {
        ISayfaManager _sayfaManager = new SayfaManager(UserHelper.Id, new EfSayfaDal());

        // GET: Sayfalar
        public ActionResult Index()
        {
            return View(_sayfaManager.Get(new Sayfa()));
        }

        public ActionResult Edit(int? id)
        {
            SayfaEditDto editDto;
            if (id == null)
            {
                editDto = new SayfaEditDto();
            }
            else
            {
                editDto = _sayfaManager.Get(Convert.ToInt32(id));
            }
            return View(editDto);
        }

        // POST: Sayfalar/Edit/5
        [HttpPost]
        public ActionResult Edit(SayfaEditDto editDto)
        {
            ViewBag.Message = "Sayfalar";
            if (editDto.Id == 0)
            {
                _sayfaManager.Add(editDto);
            }
            else
            {
                _sayfaManager.Update(editDto);
            }
            return RedirectToAction("");

        }



        // GET: Sayfalar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}