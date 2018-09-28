namespace Eticaret.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Eticaret.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Url = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        UstKategoriId = c.Int(),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false, precision: 0),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false, precision: 0),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sistem.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Soyadi = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Sifre = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        EPosta = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false, precision: 0),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false, precision: 0),
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
                        ResimYolu = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false, precision: 0),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false, precision: 0),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sanlilar.Sayfalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SayfaTipi = c.Int(nullable: false),
                        Title = c.String(maxLength: 500, storeType: "nvarchar"),
                        Html = c.String(unicode: false, storeType: "text"),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false, precision: 0),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false, precision: 0),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Eticaret.Slider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        Url = c.String(maxLength: 500, storeType: "nvarchar"),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false, precision: 0),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false, precision: 0),
                        Aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Eticaret.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        KategoriId = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(unicode: false, storeType: "text"),
                        AnaResimId = c.Int(nullable: false),
                        UrunListeTipi = c.Int(nullable: false),
                        EkleyenId = c.Int(nullable: false),
                        EklemeZamani = c.DateTime(nullable: false, precision: 0),
                        GuncelleyenId = c.Int(nullable: false),
                        GuncellemeZamani = c.DateTime(nullable: false, precision: 0),
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
        }
    }
}
