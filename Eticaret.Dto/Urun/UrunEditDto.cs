using Eticaret.Dto.Resim;
using Eticaret.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Eticaret.Dto.Urun
{
    public class UrunEditDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Adı")]
        public string Adi { get; set; }

        [Required]
        [Display(Name = "Kategori")]
        public int KategoriId { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Fiyat { get; set; }

        [Display(Name = "Açıklama")]
        [AllowHtml]
        public string Aciklama { get; set; }

        public ResimEditDto Resim { get; set; }

        [Display(Name = "AnaResim")]
        public int AnaResimId { get; set; }

        [Display(Name = "Ürün Liste Tipi")]
        public EnuUrunListeTipi UrunListeTipi { get; set; }

    }
}
