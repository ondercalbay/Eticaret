using Eticaret.Entity;

namespace Eticaret.DL.Abstract
{
    public interface ISayfaDal : IGenericDal<Sayfa>
    {
        Sayfa Get(EnuSayfaTipleri sayfaTipi);
    }
}
