using AutoMapper;
using Eticaret.DL.Abstract;
using Eticaret.Dto.Kullanici;
using Eticaret.Dto.Urun;
using Eticaret.Entity;
using Eticaret.IL;
using System;
using System.Collections.Generic;

namespace Eticaret.BL
{
    public class UrunManager : IUrunManager
    {
        private IUrunDal _dal { get; set; }
        private IKategoriDal _kategoriDal { get; set; }
        private IResimDal _resimDal { get; set; }

        public KullaniciSessionDto _user { get; set; }

        public UrunManager(KullaniciSessionDto user, IUrunDal dal, IKategoriDal kategoriDal, IResimDal resimDal)
        {
            _user = user;
            _dal = dal;
            _kategoriDal = kategoriDal;
            _resimDal = resimDal;
        }

        public UrunEditDto Add(UrunEditDto editDto)
        {
            Urun ent = Mapper.Map<Urun>(editDto);
            ent.EkleyenId = _user.Id;
            ent.EklemeZamani = DateTime.Now;
            ent.GuncelleyenId = _user.Id;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = true;
            return Mapper.Map<UrunEditDto>(_dal.Add(ent));
        }

        public void Delete(int id)
        {
            _dal.Delete(id, _user.Id);
        }

        public List<UrunListDto> Get(Urun filter)
        {
            return Mapper.Map<List<Urun>, List<UrunListDto>>(_dal.Get(filter));
        }

        public UrunEditDto Get(int id)
        {
            return Mapper.Map<UrunEditDto>(_dal.Get(id));
        }

        public UrunEditDto Update(UrunEditDto editDto)
        {
            Urun ent = Mapper.Map<Urun>(editDto);
            ent.EkleyenId = _user.Id;
            ent.EklemeZamani = DateTime.Now;

            return Mapper.Map<UrunEditDto>(_dal.Update(ent));
        }

        public List<UrunVitrinDto> Get(string kategoriUrl)
        {
            Kategori kategori = _kategoriDal.Get(kategoriUrl);
            List<Urun> urunler = _dal.Get(new Urun { KategoriId = kategori.Id });

            List<UrunVitrinDto> vitrin = new List<UrunVitrinDto>();
            foreach (var item in urunler)
            {
                vitrin.Add(new UrunVitrinDto()
                {
                    Adi = item.Adi,
                    Fiyat = item.Fiyat,
                    ResimYolu = _resimDal.Get(item.AnaResimId).ResimYolu
                });
            }

            return vitrin;
        }
    }
}
