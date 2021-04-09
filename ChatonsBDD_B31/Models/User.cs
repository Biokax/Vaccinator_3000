using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatonsBDD_B31.Models
{
    public enum Gender
    {
       Homme,
       Femme,
       Autre
    }

    public enum Category
    {
        Résident,
        Personnel
    }

    public class User
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public string firstName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public string lastName { get; set; }

        [Display(Name = "Date de naissance")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        public DateTime birthDate { get; set; }

        [Required]
        [Display(Name = "Genre")]
        [EnumDataType(typeof(Gender))]
        public virtual Gender gender { get; set; }

        [Required]
        [Display(Name = "Catégorie")]
        [EnumDataType(typeof(Category))]
        public virtual Category category { get; set; }
    }
}
