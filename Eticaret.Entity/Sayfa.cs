using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Entity
{
    [Table("Sayfalar", Schema = "Sanlilar")]
    public class Sayfa : BaseEntity
    {
        public EnuSayfaTipleri SayfaTipi { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [Column(TypeName = "Text")]
        public string Html { get; set; }
    }
}
