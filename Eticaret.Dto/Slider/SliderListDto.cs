using Eticaret.Dto.Resim;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.Dto.Slider
{
    public class SliderListDto
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Etiket")]
        public string Title { get; set; }

        public virtual ResimEditDto Resim { get; set; }
    }
}
