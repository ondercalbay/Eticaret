using Eticaret.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Eticaret.Dto.Kategori
{
    public class KategoriEditDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Adı")]
        public string Adi { get; set; }
        public string UzunAdi { get; set; }
        public string Link { get; set; }
        [Display(Name = "Üst Kategori")]
        public int? UstKategoriId { get; set; }

        [Required]
        [Display(Name = "Menü Tipi")]
        public EnuMenuTipi MenuTipi { get; set; }
        [Display(Name = "Resim")]
        public string ResimYolu { get; set; }


    }
}
