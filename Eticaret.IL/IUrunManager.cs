using Eticaret.Dto.Urun;
using Eticaret.Entity;
using System.Collections.Generic;

namespace Eticaret.IL
{
    public interface IUrunManager : IGenericManager<Urun, UrunListDto, UrunEditDto>
    {
        List<UrunVitrinDto> Get(string kategori);

        void AnaResimYap(int urunId, int resimId);

        List<UrunVitrinDto> GetUrunListe(EnuUrunListeTipi urunListeTipi);

        UrunDetailDto GetDetay(int id);
    }
}
