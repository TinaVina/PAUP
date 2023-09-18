using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ServisVozila.Models
{
    [Table("Automobil")]

    public class Automobil
    {   
        [Key]
        [Display(Name ="ID automobil")]
        public string idAutomobil { get; set; }

        [Display(Name ="Broj šasije")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public string brojSasije { get; set; }

        [Display(Name = "Registarske tablice")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public string regTablice { get; set; }

        [Display(Name = "Kilometraža")]
        public int kilometri { get; set; }

        [Display(Name = "Boja vozila")]
        public string bojaVozila { get; set; }
      
        ///////////////
 
        [Display(Name = "Marka vozila")]
        public string markaVozila { get; set; }

        ///////////////

        [Display(Name = "Model vozila")]
        public string modelVozila { get; set; }


        [Display(Name = "Godina proizvodnje")]
        public DateTime godProizvodnje { get; set; }

    }
}