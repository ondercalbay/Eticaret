using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Entity
{
    [Table("Slider", Schema = "Eticaret")]
    public class Slider : BaseEntity
    {       
        [Required]
        [Display(Name = "Etiket")]
        [MaxLength(500)]
        public string Title { get; set; }

        [Display(Name = "Url")]
        [MaxLength(500)]
        public string Url { get; set; }
    }
}

