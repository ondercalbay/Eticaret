using Eticaret.DL.Abstract;
using Eticaret.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eticaret.DL.EntityFramework
{
    public class EfSayfaDal : ISayfaDal
    {
        private EticaretContext _context = new EticaretContext();

        public EfSayfaDal()
        {
        }

        public Sayfa Add(Sayfa ent)
        {
            _context.Sayfalar.Add(ent);
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

        public List<Sayfa> Get(Sayfa filter)
        {
            return _context.Sayfalar.Where(t =>
             (filter.Id == 0 || t.Id == filter.Id) &&
             (filter.SayfaTipi == EnuSayfaTipleri.Seciniz || t.SayfaTipi == filter.SayfaTipi) &&
             t.Aktif == true).ToList();
        }

        public Sayfa Get(int id)
        {
            return _context.Sayfalar.Find(id);
        }

        public Sayfa Get(EnuSayfaTipleri sayfaTipi)
        {
            return Get(new Sayfa { SayfaTipi = sayfaTipi }).FirstOrDefault();
        }



        public Sayfa Update(Sayfa ent)
        {
            Sayfa newEnt = Get(ent.Id);
            newEnt.SayfaTipi = ent.SayfaTipi;
            newEnt.Title = ent.Title;
            newEnt.Html = ent.Html;
            newEnt.GuncelleyenId = ent.GuncelleyenId;
            newEnt.GuncellemeZamani = DateTime.Now;
            _context.SaveChanges();

            return ent;
        }
    }
}
