using Eticaret.Dto.Urun;
using Eticaret.Entity;
using System.Collections.Generic;

namespace Eticaret.IL
{
    public interface IUrunManager : IGenericManager<Urun, UrunListDto, UrunEditDto>
    {
       List<UrunVitrinDto> Get(string kategori);
    }
}
