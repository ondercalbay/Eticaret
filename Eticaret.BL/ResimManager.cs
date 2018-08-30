using AutoMapper;
using Eticaret.CommonLibrary.Helpers;
using Eticaret.DL.Abstract;
using Eticaret.Dto.Kullanici;
using Eticaret.Dto.Resim;
using Eticaret.Entity;
using Eticaret.IL;
using System;
using System.Collections.Generic;
using System.IO;

namespace Eticaret.BL
{
    public class ResimManager : IResimManager
    {
        private IResimDal _dal { get; set; }
        public KullaniciSessionDto _user { get; set; }
        public ResimManager(KullaniciSessionDto user, IResimDal dal)
        {
            _user = user;
            _dal = dal;
        }
        public ResimEditDto Add(ResimEditDto editDto)
        {
            Resim ent = Mapper.Map<Resim>(editDto);
            ent.EkleyenId = _user.Id;
            ent.EklemeZamani = DateTime.Now;
            ent.GuncelleyenId = _user.Id;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = true;
            return Mapper.Map<ResimEditDto>(_dal.Add(ent));
        }

        public void Delete(int id)
        {
            ResimEditDto resim = Get(id);
            
            string path = FileHelper.MapPath(resim.ResimYolu);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            _dal.Delete(id, _user.Id);
        }

        public List<ResimListDto> Get(Resim filter)
        {
            return Mapper.Map<List<Resim>, List<ResimListDto>>(_dal.Get(filter));
        }

        public ResimEditDto Get(int id)
        {
            return Mapper.Map<ResimEditDto>(_dal.Get(id));
        }

        public ResimEditDto Update(ResimEditDto editDto)
        {
            Resim ent = Mapper.Map<Resim>(editDto);
            ent.GuncelleyenId = _user.Id;
            ent.GuncellemeZamani = DateTime.Now;

            return Mapper.Map<ResimEditDto>(_dal.Update(ent));
        }

        public List<ResimEditDto> Get(EnuElementler elementTipi, int ElementId)
        {
            Resim filter = new Resim();
            filter.Aktif = true;
            filter.ElementTipi = elementTipi;
            filter.ElementId = ElementId;
            return Mapper.Map<List<ResimEditDto>>(_dal.Get(filter));

        }

        public void Delete(EnuElementler elementTipi, int elementId)
        {
            List<ResimEditDto> resimler = Get(elementTipi, elementId);
            foreach (var item in resimler)
            {                
                Delete(item.Id);
            }

        }
    }
}
