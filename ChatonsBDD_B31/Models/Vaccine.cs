using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatonsBDD_B31.Models
{
    public class Vaccine
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public string name { get; set; }

        [Display(Name = "Périodicité (en semaines)")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public int periodicity { get; set; }
    }
}
