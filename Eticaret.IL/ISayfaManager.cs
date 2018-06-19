using Eticaret.Dto.Sayfa;
using Eticaret.Entity;

namespace Eticaret.IL
{
    public interface ISayfaManager : IGenericManager<Sayfa, SayfaListDto, SayfaEditDto>
    {
        SayfaDetailDto Get(EnuSayfaTipleri termal_Hakkimizda);
    }
}
