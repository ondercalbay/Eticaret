using Eticaret.Entity;

namespace Eticaret.DL.Abstract
{
    public interface IKategoriDal : IGenericDal<Kategori>
    {
        Kategori Get(string kategoriUrl);
    }
}
