using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRecrutement.Models
{
    public class NiveauMaitrise
    {
        public Guid UserFk { get; set; }

        public Guid LangageFk { get; set; }

        public string Mention { get; set; }


        //prop de navig
        [ForeignKey("UserFk")]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("LangageFk")]
        public virtual Language Language { get; set; }
    }
}
