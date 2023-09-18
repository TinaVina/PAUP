using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServisVozila.Models
{
    [Table("Kvar")]
    public class kvar
    {   
        [Key]
        [Display(Name ="ID kvar")]
        [Required(ErrorMessage ="{0} je obavezan")]
        
        public string idKvar { get; set; }

        [Display(Name = "Naziv kvara")]
        [Required(ErrorMessage = "{0} je obavezan")]
        public string nazivKvar { get; set; }

        [Display(Name = "Sati potrebni")]
        public string satiPotrebni{ get; set; }


        [Display(Name = "Cijena kvara")]
        public string cijenaKvar { get; set; }
    }
}