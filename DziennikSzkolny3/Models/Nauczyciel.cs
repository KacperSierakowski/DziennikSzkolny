using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Nauczyciel
    {

        public int NauczycielID { get; set; }
        public int KlasaID { get; set; }
        //[Required]
        //[MaxLength(20)]
        //[MinLength(2)]
        public string Imie { get; set; }
        //[Required]
        //[MaxLength(20)]
        //[MinLength(2)]
        public string Nazwisko { get; set; }
        //[Required]
        public DateTime DataUrodzenia { get; set; }
        //[Phone]
        //[MaxLength(11)]
        //[MinLength(9)]
        public string Telefon { get; set; }//na zwyklego inta
        //[EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<Klasa> Klasy_Nauczyciela { get; set; }

        public virtual ICollection<Uwagi> Uwagi_Od_Nauczyciela { get; set; }
        public virtual ICollection<Ocena> Oceny_Wystawione_Przez_Nauczyciela { get; set; }
        public virtual ICollection<Frekwencja> Frekwencja_Wystawiona_Przez_Nauczyciela { get; set; }
        public virtual ICollection<Przedmiot> Przedmiot_Wykladany_Przez_Nauczyciela { get; set; }
        public virtual Adres Adres_Nauczyciela { get; set; }


        // [Required]
         public virtual Klasa Klasa_Nauczyciela { get; set; }//Wychowawca



    }
}