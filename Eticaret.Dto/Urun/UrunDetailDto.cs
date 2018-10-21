using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Eticaret.Dto.Urun
{
    public class UrunDetailDto
    {      
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Fiyat { get; set; }

        [Display(Name = "İndirimsiz Fiyat")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal IndirimsizFiyat { get; set; }

        [Display(Name = "Açıklama")]
        [AllowHtml]
        public string Aciklama { get; set; }

        public List<string> ResimYollari { get; set; }
    }
}
