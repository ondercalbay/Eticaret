using System.ComponentModel.DataAnnotations;

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
    }
}
