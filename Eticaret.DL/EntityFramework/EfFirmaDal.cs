using Eticaret.DL.Abstract;
using Eticaret.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eticaret.DL.EntityFramework
{
    public class EfFirmaDal : IFirmaDal
    {
        private EticaretContext _context = new EticaretContext();

        public Firma Add(Firma ent)
        {
            _context.Firmalar.Add(ent);
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

        public List<Firma> Get(Firma filter)
        {
            var query = _context.Firmalar.Where(t =>
         (filter.Id == 0 || t.Id == filter.Id) &&
         t.Aktif == true);
            return query.ToList();
        }

        public Firma Get(int id)
        {
            return _context.Firmalar.Find(id);
        }

        public Firma Update(Firma ent)
        {
            Firma newEnt = Get(ent.Id);
            newEnt.Adi = ent.Adi;
            newEnt.EPosta = ent.EPosta;
            newEnt.Faks = ent.Faks;
            newEnt.LogoUrl = ent.LogoUrl;
            newEnt.Telefon = ent.Telefon;
            newEnt.FaceBook = ent.FaceBook;
            newEnt.Twitter = ent.Twitter;
            newEnt.Instagram = ent.Instagram;
            newEnt.Linkedin = ent.Linkedin;


            newEnt.GuncelleyenId = ent.GuncelleyenId;
            newEnt.GuncellemeZamani = DateTime.Now;
            _context.SaveChanges();

            return ent;
        }
    }
}
