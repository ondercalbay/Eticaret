﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BL
{
    public class KategoriManager : IKategoriManager
    {
        private IKategoriDal _dal { get; set; }
        public int _userId { get; set; }
        public KategoriManager(int userId, IKategoriDal dal)
        {
            _userId = userId;
            _dal = dal;
        }

        public KategoriEditDto Add(KategoriEditDto editDto)
        {
            Kategori ent = Mapper.Map<Kategori>(editDto);
            ent.EkleyenId = _userId;
            ent.EklemeZamani = DateTime.Now;
            ent.GuncelleyenId = _userId;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = true;
            return Mapper.Map<KategoriEditDto>(_dal.Add(ent));
        }

        public void Delete(int id)
        {
            _dal.Delete(id, _userId);
        }

        public List<KategoriListDto> Get(Kategori filter)
        {
            var kategoriler = _dal.Get(filter);
            var query = kategoriler.Select(i =>
                 new KategoriListDto
                 {
                     Adi = GetAdi(i.UstKategoriId, i.Adi),
                     UstKategoriAdi = Get(i.UstKategoriId).Adi,
                     Id = i.Id
                 }
                ).OrderBy(i => i.Adi);
            return query.ToList();
        }

        private string GetAdi(int? ustKategoriId, string adi)
        {
            if (ustKategoriId != null)
            {
                var ustKategori = Get(ustKategoriId);
                adi = String.Format("{0} > {1}", GetAdi(ustKategori.UstKategoriId, ustKategori.Adi), adi);
            }
            return adi;
        }

        public KategoriEditDto Get(int id)
        {
            return Mapper.Map<KategoriEditDto>(_dal.Get(id));
        }

        public KategoriEditDto Update(KategoriEditDto editDto)
        {
            Kategori ent = Mapper.Map<Kategori>(editDto);
            ent.GuncelleyenId = _userId;
            ent.GuncellemeZamani = DateTime.Now;
            return Mapper.Map<KategoriEditDto>(_dal.Update(ent));
        }

        public KategoriEditDto Get(int? id)
        {
            if (id == null)
            {
                return new KategoriEditDto();
            }
            else
            {
                int i = Convert.ToInt32(id.ToString());
                return Mapper.Map<KategoriEditDto>(_dal.Get(i));
            }



        }
    }
}
