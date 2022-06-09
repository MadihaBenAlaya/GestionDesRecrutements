using AppRecrutement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppRecrutement.MaitriseConfiguartion
{
    public class MaitriseConfiguration : IEntityTypeConfiguration<NiveauMaitrise>
    {
        public void Configure(EntityTypeBuilder<NiveauMaitrise> builder)
        {
            builder.HasKey(f => new
            {

                f.UserFk,
                f.LangageFk            
            });
        }
    }
}
