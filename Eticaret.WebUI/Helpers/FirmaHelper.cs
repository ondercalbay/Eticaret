using Eticaret.BL;
using Eticaret.CommonLibrary.Helpers;
using Eticaret.DL.EntityFramework;
using Eticaret.Dto.Firma;
using Eticaret.IL;
using System.Web;

namespace Eticaret.WebUI.Helpers
{
    public class FirmaHelper
    {
        public static HttpApplicationState Aplication { get { return HttpContext.Current.Application; } }

        public static FirmaEditDto Firma
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    IFirmaManager servis = new FirmaManager(null, new EfFirmaDal());
                    return servis.Get(1);
                }
                else if (Aplication["Firma"].IsNull())
                {
                    IFirmaManager servis = new FirmaManager(null, new EfFirmaDal());
                    Aplication["Firma"] = servis.Get(1); ;
                }

                return Aplication["Firma"] as FirmaEditDto;
            }

            set { Aplication["Firma"] = value; }
        }

    }
}