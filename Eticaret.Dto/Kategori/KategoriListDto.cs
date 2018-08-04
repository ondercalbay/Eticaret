namespace Eticaret.Dto.Kategori
{
    public class KategoriListDto
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string UzunAdi { get; set; }
        public int? UstKategoriId { get; set; }
        public string UstKategoriAdi { get; set; }
        public int Duzey { get; set; }
    }
}
