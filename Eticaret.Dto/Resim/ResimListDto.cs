using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Dto.Resim
{
    public class ResimListDto
    {
        public int Id { get; set; }

        public EnuElementler ElementTipi { get; set; }

        public string ResimYolu { get; set; }
    }
}
