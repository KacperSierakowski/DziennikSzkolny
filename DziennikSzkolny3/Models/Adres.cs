using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DziennikSzkolny3.Models
{
    public class Adres
    {
        public int AdresID { get; set; }
        public int NauczycielID { get; set; }       //ID Urzytkownika z tabeli Adres zostało rozdzielona na dwa pola: NauczycielID i UczenID. Oba pola powinny być nullable. Powinno się rozważyć implementację mechanizmu wymuszającego wprowadzenia dokłądnie jednej z dwóch propercji (UczenID, NauczycielID)
        public int UczenID { get; set; }
        [Required]
        [MaxLength(20), MinLength(2)]
        [Display(Name = "Kraj pochodzenia")]
        public string Kraj { get; set; }
        [Required]
        [MaxLength(20), MinLength(2)]
        public string Miejscowosc { get; set; }
        [Required]
        [MaxLength(20), MinLength(2)]
        public string Ulica { get; set; }
        [Required]
        [MaxLength(20), MinLength(2)]
        [Display(Name = "Numer budynku")]
        public string NumerBudynku { get; set; }
        [Required]
        public virtual ICollection<Uczen> Uczniowie { get; set; }
        [Required]
        public virtual ICollection<Nauczyciel> Nauczyciele { get; set; }





    }
}