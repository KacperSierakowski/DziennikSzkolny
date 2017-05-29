using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class DziennikSzkolny3_DB: DbContext
    {
        public DziennikSzkolny3_DB():base()
        {

        }
        public DbSet<Nauczyciel> Nauczyciel_DB { get; set; }//
        public DbSet<Uczen> Uczen_DB { get; set; }//
        public DbSet<Klasa> Klasa_DB { get; set; }//
        public DbSet<Ocena> Ocena_DB { get; set; }//
        public DbSet<Przedmiot> Przedmiot_DB { get; set; }//
        public DbSet<Uwagi> Uwagi_DB { get; set; }//
        public DbSet<Frekwencja> Frekwencja_DB { get; set; }//
        public DbSet<Adres> Adres_DB { get; set; }//
    }
}