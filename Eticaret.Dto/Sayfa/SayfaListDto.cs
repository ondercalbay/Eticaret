using Eticaret.Entity;

namespace Eticaret.Dto.Sayfa
{
    public class SayfaListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public EnuSayfaTipleri SayfaTipi { get; set; }
    }
}
