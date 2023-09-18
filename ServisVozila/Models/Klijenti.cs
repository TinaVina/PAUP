using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace ServisVozila.Models
{
    [Table("Klijenti")]

    public class Klijenti
    {
        [Key]
        [Display(Name = "ID klijenta")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public int id { get; set; }

        [Display(Name = "OIB")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(11,MinimumLength =11, ErrorMessage = "Neispravan OIB")]
        public string oib { get; set; }

        [Display(Name = "Ime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maximalno {1} znakova")]
        public string ime { get; set; }

        [Display(Name = "Prezime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maximalno {1} znakova")]
        public string prezime { get; set; }

        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Display(Name = "Broj telefona")]
        public int brojTelefona { get; set; }

   
        [Display(Name = "Usluga")]
        [Column("usluge_sifra")]
        [ForeignKey("odabranaUsluga")]
        [Required(ErrorMessage = "{0} je obavezna")]
        public string FK_klijentKvar { get; set; }
        public virtual kvar odabranaUsluga { get; set; }

       
        [Display(Name = "ID vozila")]
        [Column("automobil_sifra")]
        [ForeignKey("KlijentovoVozilo")]

        public string FK_klijentAutomobil { get; set; }
        public virtual Automobil KlijentovoVozilo { get; set; }


   




    }
}