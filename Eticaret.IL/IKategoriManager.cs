using Eticaret.Dto.Kategori;
using Eticaret.Entity;
using System.Collections.Generic;

namespace Eticaret.IL
{
    public interface IKategoriManager : IGenericManager<Kategori, KategoriListDto, KategoriEditDto>
    {
        KategoriEditDto Get(int? id);
        List<KategoriMenuDto> GetMenu(KategoriMenuDto menu);
    }
}