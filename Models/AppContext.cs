using AppRecrutement.MaitriseConfiguartion;
using Microsoft.EntityFrameworkCore;

namespace AppRecrutement.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Candidature> Candidatures { get; set; }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<EntretienRH> EntretienRHs { get; set; }
        public DbSet<TestTechnique> TestTechniques { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<NiveauMaitrise> NiveauMaitrises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new MaitriseConfiguration());
        }
    }
}
