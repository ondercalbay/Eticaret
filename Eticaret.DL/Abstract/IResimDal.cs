using System.Collections.Generic;
using Eticaret.Entity;

namespace Eticaret.DL.Abstract
{
    public interface IResimDal : IGenericDal<Resim>
    {
        List<string> GetResimYolu(EnuElementler urun, int id);
    }
}
