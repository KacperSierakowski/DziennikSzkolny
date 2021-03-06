﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DziennikSzkolny3.Models
{
    public class Uczen
    {
        public int UczenID { get; set; }
        public int KlasaID { get; set; }
        [Required]
        [MinLength(2), MaxLength(20)]
        public string Imie { get; set; }
        [Required]
        [MinLength(2), MaxLength(30)]
        public string Nazwisko { get; set; }
        [Required]
        [Display(Name = "Data Urodzenia")]
        public DateTime DataUrodzenia { get; set; }
        [Phone]
        [MaxLength(11)]
        [MinLength(9)]
        public string Telefon { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public virtual Adres Adres { get; set; }
        public virtual Klasa KlasaUcznia { get; set; }//
        public virtual ICollection<Frekwencja> Frekwencja { get; set; }
        public virtual ICollection<Ocena> Oceny { get; set; }
        public virtual ICollection<Uwagi> Uwagi { get; set; }



    }
}