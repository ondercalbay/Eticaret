using System.Collections.Generic;

namespace Eticaret.Dto.Kategori
{
    public class KategoriMenuDto
    {
        public int Id { get; set; }

        public string Adi { get; set; }
        public string Url { get; set; }
        public List<KategoriMenuDto> AltMenuler { get; set; }
    }
}
