namespace Eticaret.DL.Migrations
{
    using Eticaret.DL.EntityFramework;
    using Eticaret.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Eticaret.DL.EntityFramework.EticaretContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EticaretContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Kullanicilar.AddOrUpdate(
             p => p.KullaniciAdi,
             new Kullanici
             {
                 Adi = "admin",
                 Soyadi = "admin",
                 KullaniciAdi = "admin",
                 Sifre = "albay69s",
                 EPosta = "ondercalbay@hotmail.com",
                 EkleyenId = 1,
                 EklemeZamani = DateTime.Now,
                 GuncelleyenId = 1,
                 GuncellemeZamani = DateTime.Now,
                 Aktif = true
             }
           );
            context.SaveChanges();
        }
    }
}
