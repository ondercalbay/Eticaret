using Eticaret.Dto.Resim;
using Eticaret.Entity;
using System.Collections.Generic;

namespace Eticaret.IL
{
    public interface IResimManager : IGenericManager<Resim, ResimListDto, ResimEditDto>
    {
        List<ResimEditDto> Get(EnuElementler elementTipi, int ElementId);

        void Delete(EnuElementler elementTipi, int ElementId);
    }
}
