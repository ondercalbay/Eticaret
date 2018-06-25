using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Dto.Urun
{
    public class UrunVitrinDto
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Adi { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Fiyat { get; set; }

        public string ResimYolu { get; set; }
    }
}
