using Eticaret.CommonLibrary.Helpers;
using Eticaret.DL.Abstract;
using Eticaret.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eticaret.DL.EntityFramework
{
    public class EfKategoriDal : IKategoriDal
    {
        private EticaretContext _context = new EticaretContext();

        public EfKategoriDal()
        {
        }

        public Kategori Add(Kategori ent)
        {
            _context.Kategoriler.Add(ent);
            _context.SaveChanges();
            return ent;
        }

        public void Delete(int id, int userId)
        {
            var ent = Get(id);
            ent.GuncelleyenId = userId;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = false;
            _context.SaveChanges();
        }

        public List<Kategori> Get(Kategori filter)
        {
            var query = _context.Kategoriler.Where(t =>
           (filter.Id == 0 || t.Id == filter.Id) &&
           (filter.UstKategoriId == null || (filter.UstKategoriId == -1 && t.UstKategoriId == null) || t.UstKategoriId == filter.UstKategoriId) &&
           (filter.Adi == null || t.Adi == filter.Adi) &&
           (filter.Url == null || t.Url == filter.Url) &&
           t.Aktif == true);
            return query.ToList();
        }

        public Kategori Get(int id)
        {
            return _context.Kategoriler.Find(id);
        }

        public Kategori Get(string kategoriUrl)
        {
            return _context.Kategoriler.Where(t => t.Url == kategoriUrl).FirstOrDefault();
        }

        public Kategori Update(Kategori ent)
        {
            Kategori newEnt = Get(ent.Id);
            newEnt.Adi = ent.Adi;
            newEnt.Url = ent.Adi.ToUrl();
            newEnt.UstKategoriId = ent.UstKategoriId;
            newEnt.MenuTipi = ent.MenuTipi;
            newEnt.ResimYolu = ent.ResimYolu;
            newEnt.GuncelleyenId = ent.GuncelleyenId;
            newEnt.GuncellemeZamani = DateTime.Now;
            _context.SaveChanges();

            return ent;
        }
    }
}
