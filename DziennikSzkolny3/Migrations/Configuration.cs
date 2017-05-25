namespace DziennikSzkolny3.Migrations
{
    using DziennikSzkolny3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DziennikSzkolny3.Models.DziennikSzkolny3_DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DziennikSzkolny3.Models.DziennikSzkolny3_DB";
        }

        protected override void Seed(DziennikSzkolny3.Models.DziennikSzkolny3_DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


           // context.Uczen_DB.AddOrUpdate(

           //   new Uczen { UczenID = 1, KlasaID = 1, Imie = "Ala", Nazwisko = "Kotowska", DataUrodzenia = DateTime.Parse("2005-09-01"), Email = "alamakota@gw.com", Telefon = "668900788" },
           //   new Uczen { UczenID = 2, KlasaID = 2, Imie = "Ola", Nazwisko = "Micka", DataUrodzenia = DateTime.Parse("2001-01-11"), Email = "ole@gw.com", Telefon = "668900781" },
           //   new Uczen { UczenID = 3, KlasaID = 1, Imie = "Pola", Nazwisko = "Smeta", DataUrodzenia = DateTime.Parse("2002-02-21"), Email = "kole@gw.com", Telefon = "668900288" },
           //   new Uczen { UczenID = 4, KlasaID = 2, Imie = "Mola", Nazwisko = "Wercka", DataUrodzenia = DateTime.Parse("2003-03-01"), Email = "paole@gw.com", Telefon = "668930788" },
           //   new Uczen { UczenID = 5, KlasaID = 1, Imie = "Lola", Nazwisko = "Morowska", DataUrodzenia = DateTime.Parse("2004-04-04"), Email = "mnie@gw.com", Telefon = "668400788" },
           //   new Uczen { UczenID = 6, KlasaID = 2, Imie = "Jarek", Nazwisko = "Katalski", DataUrodzenia = DateTime.Parse("2005-05-05"), Email = "miele@gw.com", Telefon = "658900788" },
           //   new Uczen { UczenID = 7, KlasaID = 1, Imie = "Darek", Nazwisko = "Mir", DataUrodzenia = DateTime.Parse("2016-06-16"), Email = "patole@gw.com", Telefon = "668906788" },
           //   new Uczen { UczenID = 8, KlasaID = 2, Imie = "Czarek", Nazwisko = "Zozula", DataUrodzenia = DateTime.Parse("2007-07-10"), Email = "wiorere@gw.com", Telefon = "768900788" },
           //   new Uczen { UczenID = 9, KlasaID = 1, Imie = "Marek", Nazwisko = "Kasprzyk", DataUrodzenia = DateTime.Parse("2001-07-17"), Email = "kolelele@gw.com", Telefon = "868900788" },
           //   new Uczen { UczenID = 10, KlasaID = 2, Imie = "Karol", Nazwisko = "Krucki", DataUrodzenia = DateTime.Parse("2003-01-13"), Email = "13kole12@gw.com", Telefon = "669900788" }

           //);



        }
    }
}
