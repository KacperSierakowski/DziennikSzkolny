using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Przedmiot
    {

        public int PrzedmiotID { get; set; }
        //[MaxLength(15)]
        public string Nazwa_Przedmiotu { get; set; }
        public virtual ICollection<Klasa> Klasy_Ktore_Uczace { get; set; }
        public virtual ICollection<Nauczyciel> Nauczyciele_Wykladajacy_Przedmiot { get; set; }
        public virtual ICollection<Frekwencja> Frekwencje_Na_Przedmiocie { get; set; }
        public virtual ICollection<Ocena> Oceny_Z_Przedmiotu { get; set; }

    }
}