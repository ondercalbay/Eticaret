using AutoMapper;
using Eticaret.DL.Abstract;
using Eticaret.Dto.Kullanici;
using Eticaret.Dto.Resim;
using Eticaret.Dto.Slider;
using Eticaret.Entity;
using Eticaret.IL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BL
{
    public class SliderManager : ISliderManager
    {
        private ISliderDal _dal { get; set; }
        private IResimManager _resimManager { get; set; }
        public KullaniciSessionDto _user { get; set; }
        public SliderManager(KullaniciSessionDto user, ISliderDal dal, IResimDal resimDal)
        {
            _user = user;
            _dal = dal;
            _resimManager = new ResimManager(user, resimDal);
        }
        public SliderEditDto Add(SliderEditDto editDto)
        {
            Slider ent = Mapper.Map<Slider>(editDto);
            ent.EkleyenId = _user.Id;
            ent.EklemeZamani = DateTime.Now;
            ent.GuncelleyenId = _user.Id;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = true;
            ent = _dal.Add(ent);
            SliderEditDto dto = Mapper.Map<SliderEditDto>(ent);
            editDto.Resim.ElementId = dto.Id;
            dto.Resim = _resimManager.Add(editDto.Resim);

            return dto;
        }

        public void Delete(int id)
        {
            _resimManager.Delete(EnuElementler.Slider, id);
            _dal.Delete(id, _user.Id);
        }

        public List<SliderListDto> Get(Slider filter)
        {
            return Mapper.Map<List<Slider>, List<SliderListDto>>(_dal.Get(filter));
        }

        public SliderEditDto Get(int id)
        {
            SliderEditDto sliderDto = Mapper.Map<Slider, SliderEditDto>(_dal.Get(id));
            sliderDto.Resim = _resimManager.Get(EnuElementler.Slider, id).FirstOrDefault();
            return sliderDto;
        }

        public SliderEditDto Update(SliderEditDto editDto)
        {
            Slider ent = Mapper.Map<Slider>(editDto);
            ent.GuncelleyenId = _user.Id;
            SliderEditDto dto = Mapper.Map<SliderEditDto>(ent);
            if (!(editDto.Resim is null))
            {
                editDto.Resim.ElementId = dto.Id;
                editDto.Resim.ElementTipi = EnuElementler.Slider;
                dto.Resim = _resimManager.Update(editDto.Resim);
            }


            return Mapper.Map<SliderEditDto>(_dal.Update(ent));
        }
    }
}
