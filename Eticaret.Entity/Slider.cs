using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Entity
{
    [Table("Slider", Schema = "Eticaret")]
    public class Slider : BaseEntity
    {       
        [Required]
        [Display(Name = "Etiket")]
        public string Title { get; set; }

        [Display(Name = "Url")]
        public string Url { get; set; }
    }
}

