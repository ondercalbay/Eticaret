using Eticaret.Dto.Resim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Dto.Urun
{
    public class UrunResimEkleDto
    {
        public int Id { get; set; }

        public List<ResimListDto> Resimler { get; set; }
    }
}
