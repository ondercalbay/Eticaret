using Eticaret.Entity;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.Dto.Resim
{
    public class ResimEditDto
    {
        public int Id { get; set; }

        [Required]
        public EnuElementler ElementTipi { get; set; }

        [Required]
        public int ElementId { get; set; }

        [Required]
        public string ResimYolu { get; set; }

    }
}
