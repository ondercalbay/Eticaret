using Eticaret.DL.Abstract;
using Eticaret.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eticaret.DL.EntityFramework
{
    public class EfUrunDal : IUrunDal
    {
        private EticaretContext _context = new EticaretContext();

        public Urun Add(Urun ent)
        {
            _context.Urunler.Add(ent);
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

        public List<Urun> Get(Urun filter)
        {
            return _context.Urunler.Where(t =>
             (filter.Id == 0 || t.Id == filter.Id) &&
             (filter.KategoriId == 0 || t.KategoriId == filter.KategoriId) &&
             (filter.UrunListeTipi == 0 || t.UrunListeTipi == filter.UrunListeTipi) &&
             t.Aktif == true).ToList();
        }

        public Urun Get(int id)
        {
            return _context.Urunler.Find(id);
        }

        public Urun Update(Urun ent)
        {
            Urun newEnt = Get(ent.Id);
            newEnt.Adi = ent.Adi;
            newEnt.Fiyat = ent.Fiyat;
            newEnt.KategoriId = ent.KategoriId;
            newEnt.Aciklama = ent.Aciklama;
            newEnt.UrunListeTipi = ent.UrunListeTipi;
            newEnt.GuncelleyenId = ent.GuncelleyenId;
            newEnt.GuncellemeZamani = DateTime.Now;
            _context.SaveChanges();

            return ent;
        }

        public void AnaResimGuncelle(int id, int resimId,int kullaniciId)
        {
            Urun newEnt = Get(id);            
            newEnt.AnaResimId = resimId;
            newEnt.GuncelleyenId = kullaniciId;
            newEnt.GuncellemeZamani = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
