using Eticaret.Dto.Kullanici;
using Eticaret.Entity;

namespace Eticaret.IL
{
    public interface IKullaniciManager : IGenericManager<Kullanici, KullaniciListDto, KullaniciEditDto>
    {
        KullaniciSessionDto Authenticate(KullaniciLoginDto kullanici);
    }
}
