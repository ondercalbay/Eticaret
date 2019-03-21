using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Entity
{
    [Table("Kategoriler", Schema = "Eticaret")]
    public class Kategori : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Adi { get; set; }

        [Required]
        [MaxLength(100)]
        public string Url { get; set; }

        public int? UstKategoriId { get; set; }


        [Required]
        public EnuMenuTipi MenuTipi { get; set; }

        public string ResimYolu { get; set; }
    }
}
