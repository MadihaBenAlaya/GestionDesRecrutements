using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRecrutement.Models
{
    //[Table("Langages")]
    public class Language
    {
        public Language()
        {
        }

        [Key]
        public Guid LanguageID { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
