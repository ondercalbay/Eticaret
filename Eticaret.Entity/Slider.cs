using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Entity
{
    [Table("Slider", Schema = "Eticaret")]
    public class Slider : BaseEntity
    {
        [Required]
        public string ResimId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}

