using System.ComponentModel.DataAnnotations;

namespace Eticaret.Entity
{
    public enum EnuSayfaTipleri
    {
        [Display(Name = "Seçiniz")]
        Seciniz = 0,
        [Display(Name = "Anasayfa")]
        AnaSayfa = 1,
        [Display(Name = "Hakkımızda")]
        Hakkimizda = 2,        
        [Display(Name = "İletişim")]
        Iletisim = 4
    }

    public enum EnuElementler
    {
        Urun = 1,
        Slider = 2
    }

    public enum EnuUrunListeTipi
    {
        [Display(Name = "Normal")]
        Normal = 0,
        [Display(Name = "Çok Satanlar")]
        CokSatanlar = 1,
        [Display(Name = "Yeniler")]
        Yeniler = 2,
        [Display(Name = "İndirimdekiler")]
        Indrimdekiler = 3
    }
}
