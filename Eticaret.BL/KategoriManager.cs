using AutoMapper;
using Eticaret.CommonLibrary.Helpers;
using Eticaret.DL.Abstract;
using Eticaret.Dto.Kategori;
using Eticaret.Dto.Kullanici;
using Eticaret.Entity;
using Eticaret.IL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eticaret.BL
{
    public class KategoriManager : IKategoriManager
    {
        private IKategoriDal _dal { get; set; }
        public KullaniciSessionDto _user { get; set; }
        public KategoriManager(KullaniciSessionDto user, IKategoriDal dal)
        {
            _user = user;
            _dal = dal;
        }

        public KategoriEditDto Add(KategoriEditDto editDto)
        {
            Kategori ent = Mapper.Map<Kategori>(editDto);
            ent.Url = ent.Adi.ToUrl();
            ent.EkleyenId = _user.Id;
            ent.EklemeZamani = DateTime.Now;
            ent.GuncelleyenId = _user.Id;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = true;
            return Mapper.Map<KategoriEditDto>(_dal.Add(ent));
        }

        public void Delete(int id)
        {
            _dal.Delete(id, _user.Id);
        }

        public List<KategoriListDto> Get(Kategori filter)
        {
            var kategoriler = _dal.Get(filter);
            var query = kategoriler.Select(i =>
                 new KategoriListDto
                 {
                     Adi = i.Adi,
                     UzunAdi = GetAdi(i.UstKategoriId, i.Adi),
                     UstKategoriAdi = Get(i.UstKategoriId).Adi,
                     Id = i.Id
                 }
                ).OrderBy(i => i.UzunAdi);
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
            ent.GuncelleyenId = _user.Id;            
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
                KategoriEditDto dto = Mapper.Map<KategoriEditDto>(_dal.Get(i));
                dto.UzunAdi = GetAdi(dto.UstKategoriId, dto.Adi);
                return dto;
            }
        }

        public List<KategoriMenuDto> GetMenu(KategoriMenuDto menu)
        {
            var filter = new Kategori() { UstKategoriId = menu.Id, Aktif = true };
            var altKategoriler = _dal.Get(filter);
            List<KategoriMenuDto> altmenuler = new List<KategoriMenuDto>();
            foreach (var item in altKategoriler)
            {
                KategoriMenuDto altMenu = new KategoriMenuDto();
                altMenu.Id = item.Id;
                altMenu.Adi = item.Adi;
                altMenu.Url = item.Url;
                altMenu.MenuTipi = item.MenuTipi;
                altMenu.ResimYolu = item.ResimYolu;
                altMenu.AltMenuler = GetMenu(altMenu);
                altmenuler.Add(altMenu);
            }            
           
            return altmenuler;
        }
    }
}
