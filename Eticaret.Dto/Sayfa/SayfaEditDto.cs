using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Dto.Sayfa
{
    public class SayfaEditDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [AllowHtml]
        public string Html { get; set; }
        [Required]
        public EnuSayfaTipleri SayfaTipi { get; set; }
    }
}
