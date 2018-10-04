namespace Eticaret.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Eticaret.Firmalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 200),
                        LogoUrl = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 100),
                        Faks = c.String(maxLength: 100),
                        EPosta = c.String(maxLength: 200),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Eticaret.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 100),
                        Url = c.String(nullable: false, maxLength: 100),
                        UstKategoriId = c.Int(),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sistem.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        Soyadi = c.String(nullable: false, maxLength: 50),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 20),
                        EPosta = c.String(nullable: false, maxLength: 100),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sistem.Resimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ElementTipi = c.Int(nullable: false),
                        ElementId = c.Int(nullable: false),
                        ResimYolu = c.String(nullable: false, maxLength: 200),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sanlilar.Sayfalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SayfaTipi = c.Int(nullable: false),
                        Title = c.String(maxLength: 500),
                        Html = c.String(unicode: false, storeType: "text"),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Eticaret.Slider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500),
                        Url = c.String(maxLength: 500),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Eticaret.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 100),
                        KategoriId = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(unicode: false, storeType: "text"),
                        AnaResimId = c.Int(nullable: false),
                        UrunListeTipi = c.Int(nullable: false),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Eticaret.Urunler");
            DropTable("Eticaret.Slider");
            DropTable("Sanlilar.Sayfalar");
            DropTable("Sistem.Resimler");
            DropTable("Sistem.Kullanicilar");
            DropTable("Eticaret.Kategoriler");
            DropTable("Eticaret.Firmalar");
        }
    }
}
