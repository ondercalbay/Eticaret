using Eticaret.Dto.Resim;
using System.Collections.Generic;

namespace Eticaret.Dto.Urun
{
    public class UrunResimEkleDto
    {
        public int Id { get; set; }

        public List<ResimListDto> Resimler { get; set; }
    }
}
