﻿using Eticaret.BL;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Kategori;
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
    public class KategorilerController : Controller
    {
        IKategoriManager _manager = new KategoriManager(UserHelper.Kullanici, new EfKategoriDal());
        // GET: Kategoriler
        public ActionResult Index(string Kategori)
        {
            var kategori = _manager.Get(new Kategori() { Url = Kategori }).FirstOrDefault();
            ViewBag.Title = kategori.UzunAdi;
            return View(_manager.GetMenu(new KategoriMenuDto() { Id = kategori.Id }));
        }

        // GET: Kategoriler/Edit/5
        public ActionResult Edit(int? id, int? ustKategoriId)
        {
            KategoriEditDto editDto;
            if (id == null)
            {
                editDto = new KategoriEditDto();
                if (ustKategoriId != null)
                {
                    editDto.UstKategoriId = ustKategoriId;
                }
            }
            else
            {
                editDto = _manager.Get(id);
            }

            IEnumerable<KategoriListDto> kategoriler = _manager.Get(new Kategori());
            List<SelectListItem> selectkategoriler = new SelectList(kategoriler, "Id", "Adi", editDto.UstKategoriId).ToList();

            selectkategoriler.Insert(0, new SelectListItem() { Value = "", Text = "Seçiniz" });
            ViewBag.UstKategoriId = selectkategoriler;
            return View(editDto);
        }

        // POST: Kategoriler/Edit/5
        [HttpPost]
        public ActionResult Edit(KategoriEditDto editDto)
        {
            ViewBag.Message = "Sayfalar";
            ViewBag.UstKategoriler = _manager.Get(new Kategori());
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

        // GET: Kategoriler/Delete/5
        public ActionResult Delete(int id)
        {
            _manager.Delete(id);
            return RedirectToAction("");
        }

        // POST: Kategoriler/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _manager.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}