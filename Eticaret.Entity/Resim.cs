using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Entity
{
    [Table("Resimler", Schema = "Sistem")]
    public class Resim : BaseEntity
    {
        [Required]
        public EnuElementler ElementTipi { get; set; }

        [Required]
        public int ElementId { get; set; }

        [Required]
        [MaxLength(200)]
        public string ResimYolu { get; set; }

    }
}
