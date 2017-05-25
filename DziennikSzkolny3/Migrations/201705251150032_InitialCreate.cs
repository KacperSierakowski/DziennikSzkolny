namespace DziennikSzkolny3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        AdresID = c.Int(nullable: false, identity: true),
                        NauczycielID = c.Int(nullable: false),
                        UczenID = c.Int(nullable: false),
                        Kraj = c.String(),
                        Miejscowosc = c.String(),
                        Ulica = c.String(),
                        NumerBudynku = c.String(),
                    })
                .PrimaryKey(t => t.AdresID);
            
            CreateTable(
                "dbo.Nauczyciels",
                c => new
                    {
                        NauczycielID = c.Int(nullable: false, identity: true),
                        KlasaID = c.Int(nullable: false),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        DataUrodzenia = c.DateTime(nullable: false),
                        Telefon = c.String(),
                        Email = c.String(),
                        Adres_Nauczyciela_AdresID = c.Int(),
                        Klasa_KlasaID = c.Int(),
                        Klasa_Nauczyciela_KlasaID = c.Int(),
                    })
                .PrimaryKey(t => t.NauczycielID)
                .ForeignKey("dbo.Adres", t => t.Adres_Nauczyciela_AdresID)
                .ForeignKey("dbo.Klasas", t => t.Klasa_KlasaID)
                .ForeignKey("dbo.Klasas", t => t.Klasa_Nauczyciela_KlasaID)
                .Index(t => t.Adres_Nauczyciela_AdresID)
                .Index(t => t.Klasa_KlasaID)
                .Index(t => t.Klasa_Nauczyciela_KlasaID);
            
            CreateTable(
                "dbo.Frekwencjas",
                c => new
                    {
                        FrekwencjaID = c.Int(nullable: false, identity: true),
                        UczenID = c.Int(nullable: false),
                        NauczycielID = c.Int(nullable: false),
                        PrzedmiotID = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FrekwencjaID)
                .ForeignKey("dbo.Nauczyciels", t => t.NauczycielID, cascadeDelete: true)
                .ForeignKey("dbo.Przedmiots", t => t.PrzedmiotID, cascadeDelete: true)
                .ForeignKey("dbo.Uczens", t => t.UczenID, cascadeDelete: true)
                .Index(t => t.UczenID)
                .Index(t => t.NauczycielID)
                .Index(t => t.PrzedmiotID);
            
            CreateTable(
                "dbo.Przedmiots",
                c => new
                    {
                        PrzedmiotID = c.Int(nullable: false, identity: true),
                        Nazwa_Przedmiotu = c.String(),
                    })
                .PrimaryKey(t => t.PrzedmiotID);
            
            CreateTable(
                "dbo.Klasas",
                c => new
                    {
                        KlasaID = c.Int(nullable: false, identity: true),
                        NauczycielID = c.Int(nullable: false),
                        Nazwa = c.String(),
                        NauczycielKlasy_NauczycielID = c.Int(),
                        Nauczyciel_NauczycielID = c.Int(),
                    })
                .PrimaryKey(t => t.KlasaID)
                .ForeignKey("dbo.Nauczyciels", t => t.NauczycielKlasy_NauczycielID)
                .ForeignKey("dbo.Nauczyciels", t => t.Nauczyciel_NauczycielID)
                .Index(t => t.NauczycielKlasy_NauczycielID)
                .Index(t => t.Nauczyciel_NauczycielID);
            
            CreateTable(
                "dbo.Uczens",
                c => new
                    {
                        UczenID = c.Int(nullable: false, identity: true),
                        KlasaID = c.Int(nullable: false),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        DataUrodzenia = c.DateTime(nullable: false),
                        Telefon = c.String(),
                        Email = c.String(),
                        Adres_AdresID = c.Int(),
                    })
                .PrimaryKey(t => t.UczenID)
                .ForeignKey("dbo.Adres", t => t.Adres_AdresID)
                .ForeignKey("dbo.Klasas", t => t.KlasaID, cascadeDelete: true)
                .Index(t => t.KlasaID)
                .Index(t => t.Adres_AdresID);
            
            CreateTable(
                "dbo.Ocenas",
                c => new
                    {
                        OcenaID = c.Int(nullable: false, identity: true),
                        NauczycielID = c.Int(nullable: false),
                        UczenID = c.Int(nullable: false),
                        PrzedmiotID = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Waga = c.Int(nullable: false),
                        Wartosc = c.Int(nullable: false),
                        Komentarz = c.String(),
                    })
                .PrimaryKey(t => t.OcenaID)
                .ForeignKey("dbo.Nauczyciels", t => t.NauczycielID, cascadeDelete: true)
                .ForeignKey("dbo.Przedmiots", t => t.PrzedmiotID, cascadeDelete: true)
                .ForeignKey("dbo.Uczens", t => t.UczenID, cascadeDelete: true)
                .Index(t => t.NauczycielID)
                .Index(t => t.UczenID)
                .Index(t => t.PrzedmiotID);
            
            CreateTable(
                "dbo.Uwagis",
                c => new
                    {
                        UwagiID = c.Int(nullable: false, identity: true),
                        NauczycielID = c.Int(nullable: false),
                        UczenID = c.Int(nullable: false),
                        Uwaga = c.String(),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UwagiID)
                .ForeignKey("dbo.Nauczyciels", t => t.NauczycielID, cascadeDelete: true)
                .ForeignKey("dbo.Uczens", t => t.UczenID, cascadeDelete: true)
                .Index(t => t.NauczycielID)
                .Index(t => t.UczenID);
            
            CreateTable(
                "dbo.KlasaPrzedmiots",
                c => new
                    {
                        Klasa_KlasaID = c.Int(nullable: false),
                        Przedmiot_PrzedmiotID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Klasa_KlasaID, t.Przedmiot_PrzedmiotID })
                .ForeignKey("dbo.Klasas", t => t.Klasa_KlasaID, cascadeDelete: true)
                .ForeignKey("dbo.Przedmiots", t => t.Przedmiot_PrzedmiotID, cascadeDelete: true)
                .Index(t => t.Klasa_KlasaID)
                .Index(t => t.Przedmiot_PrzedmiotID);
            
            CreateTable(
                "dbo.PrzedmiotNauczyciels",
                c => new
                    {
                        Przedmiot_PrzedmiotID = c.Int(nullable: false),
                        Nauczyciel_NauczycielID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Przedmiot_PrzedmiotID, t.Nauczyciel_NauczycielID })
                .ForeignKey("dbo.Przedmiots", t => t.Przedmiot_PrzedmiotID, cascadeDelete: true)
                .ForeignKey("dbo.Nauczyciels", t => t.Nauczyciel_NauczycielID, cascadeDelete: true)
                .Index(t => t.Przedmiot_PrzedmiotID)
                .Index(t => t.Nauczyciel_NauczycielID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Klasas", "Nauczyciel_NauczycielID", "dbo.Nauczyciels");
            DropForeignKey("dbo.Nauczyciels", "Klasa_Nauczyciela_KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.PrzedmiotNauczyciels", "Nauczyciel_NauczycielID", "dbo.Nauczyciels");
            DropForeignKey("dbo.PrzedmiotNauczyciels", "Przedmiot_PrzedmiotID", "dbo.Przedmiots");
            DropForeignKey("dbo.Uwagis", "UczenID", "dbo.Uczens");
            DropForeignKey("dbo.Uwagis", "NauczycielID", "dbo.Nauczyciels");
            DropForeignKey("dbo.Ocenas", "UczenID", "dbo.Uczens");
            DropForeignKey("dbo.Ocenas", "PrzedmiotID", "dbo.Przedmiots");
            DropForeignKey("dbo.Ocenas", "NauczycielID", "dbo.Nauczyciels");
            DropForeignKey("dbo.Uczens", "KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.Frekwencjas", "UczenID", "dbo.Uczens");
            DropForeignKey("dbo.Uczens", "Adres_AdresID", "dbo.Adres");
            DropForeignKey("dbo.KlasaPrzedmiots", "Przedmiot_PrzedmiotID", "dbo.Przedmiots");
            DropForeignKey("dbo.KlasaPrzedmiots", "Klasa_KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.Klasas", "NauczycielKlasy_NauczycielID", "dbo.Nauczyciels");
            DropForeignKey("dbo.Nauczyciels", "Klasa_KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.Frekwencjas", "PrzedmiotID", "dbo.Przedmiots");
            DropForeignKey("dbo.Frekwencjas", "NauczycielID", "dbo.Nauczyciels");
            DropForeignKey("dbo.Nauczyciels", "Adres_Nauczyciela_AdresID", "dbo.Adres");
            DropIndex("dbo.PrzedmiotNauczyciels", new[] { "Nauczyciel_NauczycielID" });
            DropIndex("dbo.PrzedmiotNauczyciels", new[] { "Przedmiot_PrzedmiotID" });
            DropIndex("dbo.KlasaPrzedmiots", new[] { "Przedmiot_PrzedmiotID" });
            DropIndex("dbo.KlasaPrzedmiots", new[] { "Klasa_KlasaID" });
            DropIndex("dbo.Uwagis", new[] { "UczenID" });
            DropIndex("dbo.Uwagis", new[] { "NauczycielID" });
            DropIndex("dbo.Ocenas", new[] { "PrzedmiotID" });
            DropIndex("dbo.Ocenas", new[] { "UczenID" });
            DropIndex("dbo.Ocenas", new[] { "NauczycielID" });
            DropIndex("dbo.Uczens", new[] { "Adres_AdresID" });
            DropIndex("dbo.Uczens", new[] { "KlasaID" });
            DropIndex("dbo.Klasas", new[] { "Nauczyciel_NauczycielID" });
            DropIndex("dbo.Klasas", new[] { "NauczycielKlasy_NauczycielID" });
            DropIndex("dbo.Frekwencjas", new[] { "PrzedmiotID" });
            DropIndex("dbo.Frekwencjas", new[] { "NauczycielID" });
            DropIndex("dbo.Frekwencjas", new[] { "UczenID" });
            DropIndex("dbo.Nauczyciels", new[] { "Klasa_Nauczyciela_KlasaID" });
            DropIndex("dbo.Nauczyciels", new[] { "Klasa_KlasaID" });
            DropIndex("dbo.Nauczyciels", new[] { "Adres_Nauczyciela_AdresID" });
            DropTable("dbo.PrzedmiotNauczyciels");
            DropTable("dbo.KlasaPrzedmiots");
            DropTable("dbo.Uwagis");
            DropTable("dbo.Ocenas");
            DropTable("dbo.Uczens");
            DropTable("dbo.Klasas");
            DropTable("dbo.Przedmiots");
            DropTable("dbo.Frekwencjas");
            DropTable("dbo.Nauczyciels");
            DropTable("dbo.Adres");
        }
    }
}
