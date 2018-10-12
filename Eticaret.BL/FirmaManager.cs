using AutoMapper;
using Eticaret.DL.Abstract;
using Eticaret.Dto.Firma;
using Eticaret.Dto.Kullanici;
using Eticaret.Entity;
using Eticaret.IL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BL
{
    public class FirmaManager : IFirmaManager
    {
        private IFirmaDal _dal { get; set; }

        public KullaniciSessionDto _user { get; set; }
        public FirmaManager(KullaniciSessionDto user, IFirmaDal dal)
        {
            _user = user;
            _dal = dal;
        }

        public FirmaEditDto Add(FirmaEditDto editDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FirmaListDto> Get(Firma filter)
        {
            throw new NotImplementedException();
        }

        public FirmaEditDto Get(int id)
        {
            return Mapper.Map<FirmaEditDto>(_dal.Get(id));
        }

        public FirmaEditDto Update(FirmaEditDto editDto)
        {
            Firma ent = Mapper.Map<Firma>(editDto);
            ent.GuncelleyenId = _user.Id;
            return Mapper.Map<FirmaEditDto>(_dal.Update(ent));
        }
    }
}
