using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Entity
{
    [Table("Sayfalar", Schema = "Sanlilar")]
    public class Sayfa : BaseEntity
    {
        public EnuSayfaTipleri SayfaTipi { get; set; }
        public string Title { get; set; }
        public string Html { get; set; }
    }
}
