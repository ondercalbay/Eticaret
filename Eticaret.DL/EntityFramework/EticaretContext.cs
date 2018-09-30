using Eticaret.Entity;
using System.Data.Entity;

namespace Eticaret.DL.EntityFramework
{
    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class EticaretContext : DbContext
    {
        public DbSet<Sayfa> Sayfalar { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Resim> Resimler { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Slider> Sliderlar { get; set; }

        public DbSet<Firma> Firmalar { get; set; }
    }
}
