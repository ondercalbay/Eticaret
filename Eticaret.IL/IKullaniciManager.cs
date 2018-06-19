using Eticaret.Dto.Kullanici;
using Eticaret.Entity;

namespace Eticaret.IL
{
    public interface IKullaniciManager : IGenericManager<Kullanici, KullaniciListDto, KullaniciEditDto>
    {
        KullaniciEditDto Authenticate(KullaniciLoginDto kullanici);
    }
}
