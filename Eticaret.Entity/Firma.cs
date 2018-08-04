using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Entity
{
    [Table("Kategoriler", Schema = "Eticaret")]
    public class Firma : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Adi { get; set; }

        [MaxLength(100)]
        public string LogoUrl { get; set; }

        [MaxLength(100)]
        public string Telefon { get; set; }
        [MaxLength(100)]
        public string Faks { get; set; }

        [MaxLength(200)]
        public string EPosta { get; set; }

    }
}
