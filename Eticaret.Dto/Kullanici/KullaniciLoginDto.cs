using System.ComponentModel.DataAnnotations;

namespace Eticaret.Dto.Kullanici
{
    public class KullaniciLoginDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}
