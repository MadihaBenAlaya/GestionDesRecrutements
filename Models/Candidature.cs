using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AppRecrutement.Enums.Enums;

namespace AppRecrutement.Models
{
    //[Table("Candidatures")]
    public class Candidature
    {
            public Candidature()
            {
            }

            [Key]
            public Guid CandidatureID { get; }


            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [Display(Name = "Date de postulation")]
            public string Date_postulation { get; set; }


            public ETAT Etat { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Motivation par rapport au poste")]
            public string Motivation_poste { get; private set; }


            [DataType(DataType.Text)]
            public string Questions { get; set; }

            [Required]
            [Display(Name = "Curriculum Vitae")]
            public string Curriculum_Vitae { get; set; }

            [Required]
            [Display(Name = "Letrre de motivation")]
            public string Letrre_motivation { get; set; }

            public virtual ApplicationUser Candidat { get; set; }

            public virtual Offre Correspondance { get; set; }
    }
    
}
