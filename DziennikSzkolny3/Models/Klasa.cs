using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Klasa
    {
        public int KlasaID { get; set; }
        public int NauczycielID { get; set; }
        [MaxLength(20), MinLength(2)]
        [Display(Name = "Nazwa klasy")]
        public string Nazwa { get; set; }


        public virtual ICollection<Przedmiot> Przedmioty { get; set; }
        public virtual ICollection<Nauczyciel> Nauczyciele_Uczacy_Klase { get; set; }


        public virtual Nauczyciel NauczycielKlasy { get; set; }//Wychowaca
        public virtual ICollection<Uczen> Uczniowie { get; set; }////





    }
}