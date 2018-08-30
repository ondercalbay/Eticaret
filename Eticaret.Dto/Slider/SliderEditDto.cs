using Eticaret.Dto.Resim;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.Dto.Slider
{
    public class SliderEditDto
    {
        public int Id { get; set; }

        [Required]
        public string ResimId { get; set; }

        [Required]
        [Display(Name = "Etiket")]
        public string Title { get; set; }

        [Display(Name = "Url")]
        public string Url { get; set; }

        public virtual ResimEditDto Resim { get; set; }
    }
}
