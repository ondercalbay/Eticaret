using Eticaret.Dto.Kategori;
using Eticaret.Entity;

namespace Eticaret.IL
{
    public interface IKategoriManager : IGenericManager<Kategori, KategoriListDto, KategoriEditDto>
    {
        KategoriEditDto Get(int? id);
    }
}
