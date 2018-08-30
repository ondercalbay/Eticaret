using Eticaret.DL.Abstract;
using Eticaret.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eticaret.DL.EntityFramework
{
    public class EfSliderDal : ISliderDal
    {
        private EticaretContext _context = new EticaretContext();

        public Slider Add(Slider ent)
        {
            _context.Sliderlar.Add(ent);
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

        public List<Slider> Get(Slider filter)
        {
            var query = _context.Sliderlar.Where(t =>
             (filter.Id == 0 || t.Id == filter.Id) &&             
             t.Aktif == true);
            return query.ToList();
        }

        public Slider Get(int id)
        {
            return _context.Sliderlar.Find(id);
        }

        public Slider Update(Slider ent)
        {
            Slider newEnt = Get(ent.Id);
            
            newEnt.Url = ent.Url;
            newEnt.Title = ent.Title;
            newEnt.GuncelleyenId = ent.GuncelleyenId;
            newEnt.GuncellemeZamani = DateTime.Now;
            _context.SaveChanges();

            return ent;
        }
    }
}
