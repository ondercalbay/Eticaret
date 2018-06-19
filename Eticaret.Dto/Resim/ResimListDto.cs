using Eticaret.Entity;

namespace Eticaret.Dto.Resim
{
    public class ResimListDto
    {
        public int Id { get; set; }

        public EnuElementler ElementTipi { get; set; }

        public string ResimYolu { get; set; }
    }
}
