using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Klasa
    {
        public int KlasaID { get; set; }
        public int NauczycielID { get; set; }

        public string Nazwa { get; set; }


        public virtual ICollection<Przedmiot> Przedmioty { get; set; }
        public virtual ICollection<Nauczyciel> Nauczyciele_Uczacy_Klase { get; set; }


        public virtual Nauczyciel NauczycielKlasy { get; set; }//Wychowaca
        public virtual ICollection<Uczen> Uczniowie { get; set; }////





    }
}