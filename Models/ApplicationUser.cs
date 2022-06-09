using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AppRecrutement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column]
        public string FullName { get; set; }

        [Column]
        public string Pays { get; set; }

        [Column]
        public string Ville { get; set; }

        [Column]
        [Display(Name = "Niveau d'étude")]
        public string Niveau_etude { get; set; }

        [Column]
        public string Ecole { get; set; }

        [Column]
        public string Spécialité { get; set; }


        [Column]
        [Display(Name = "Situation d'emploi actuelle")]
        public string Situation_emploi_actuelle { get; set; }


        [Column]
        [Display(Name = "Nombre d'années d'expérience")]
        public int Nb_années_expérience { get; set; }

        [Column]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de naissance")]
        public string Date_naissance { get; set; }


        [Column]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de début disponible")]
        public string Date_début_dispo { get; set; }

        public float Score { get; set; }

        public virtual ICollection<Candidature> Candidatures { get; set; }

        public virtual Departement Departements { get; set; }

        public virtual ICollection<Language> Languages { get; set; }

    }
}
