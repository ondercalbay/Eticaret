using Eticaret.Entity;

namespace Eticaret.DL.Abstract
{
    public interface IUrunDal : IGenericDal<Urun>
    {
        void AnaResimGuncelle(int urunId, int resimId, int ıd);
    }
}
