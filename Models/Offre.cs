using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRecrutement.Models
{
    //[Table("Offres")]
    public class Offre
    {
        public Offre()
        {
        }

        [Key]
        public Guid OffreID { get; set; }

        [Required]
        public string NomOffre { get; set; }

        [Required]
        public string Département { get; set; }

        [Required]
        public string Pays { get; set; }

        [Required]
        public string Région { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de début")]
        public string Date_début { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Activités principales")]
        public string Activités_principales { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Qualités interpersonnelles")]
        public string Qualités_interpersonnelles { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Compétences techniques")]
        public string Compétences_techniques { get; set; }

        [Required]
        [Display(Name = "Diplome démandé")]
        public string Diplome_démandé { get; set; }

        [Required]
        [Display(Name = "Experience démandée")]
        public string Experience_démandée { get; set; }

        [Required]
        [Display(Name = "Niveau démandé")]
        public string Niveau_démandé { get; set; }

        public long salaire { get; set; }

        [Display(Name = "Type de contrat")]
        public string Type_contrat { get; set; }

        public virtual ICollection<EntretienRH> EntretienRHs { get; set; }

        public virtual ICollection<Candidature> CandidaturesOffre { get; set; }

        public virtual ICollection<TestTechnique> Tests { get; set; }
    }
}
