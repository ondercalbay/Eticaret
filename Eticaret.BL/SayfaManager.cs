using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.BL
{
    public class SayfaManager : ISayfaManager
    {
        private ISayfaDal _dal { get; set; }
        public int _userId { get; set; }
        public SayfaManager(int userId, ISayfaDal dal)
        {
            _userId = userId;
            _dal = dal;
        }

        public SayfaEditDto Add(SayfaEditDto editDto)
        {
            Sayfa ent = Mapper.Map<Sayfa>(editDto);
            ent.EkleyenId = _userId;
            ent.EklemeZamani = DateTime.Now;
            ent.GuncelleyenId = _userId;
            ent.GuncellemeZamani = DateTime.Now;
            ent.Aktif = true;
            return Mapper.Map<SayfaEditDto>(_dal.Add(ent));
        }

        public void Delete(int id)
        {
            _dal.Delete(id, _userId);
        }

        public List<SayfaListDto> Get(Sayfa filter)
        {
            return Mapper.Map<List<Sayfa>, List<SayfaListDto>>(_dal.Get(filter));
        }

        public SayfaEditDto Get(int id)
        {
            return Mapper.Map<SayfaEditDto>(_dal.Get(id));
        }

        public SayfaEditDto Update(SayfaEditDto editDto)
        {
            Sayfa ent = Mapper.Map<Sayfa>(editDto);
            ent.GuncelleyenId = _userId;
            ent.GuncellemeZamani = DateTime.Now;
            return Mapper.Map<SayfaEditDto>(_dal.Update(ent));
        }

        public SayfaDetailDto Get(EnuSayfaTipleri sayfaTipi)
        {
            return Mapper.Map<SayfaDetailDto>(_dal.Get(sayfaTipi));
        }
    }
}
