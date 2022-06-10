using AppRecrutement.MaitriseConfiguartion;
using Microsoft.EntityFrameworkCore;

namespace AppRecrutement.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
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

            


            //modelBuilder.Entity<Candidature>().ToTable("Candidatures");
            //modelBuilder.Entity<Offre>().ToTable("Offres");
            //modelBuilder.Entity<EntretienRH>().ToTable("EntretienRHs");
            //modelBuilder.Entity<TestTechnique>().ToTable("TestTechniques");
            //modelBuilder.Entity<Departement>().ToTable("Departements");
            //modelBuilder.Entity<Language>().ToTable("Languages");
            //modelBuilder.Entity<NiveauMaitrise>().ToTable("NiveauMaitrises");

            /*modelBuilder.Entity<NiveauMaitrise>()
                    .HasOne(a => a.User)
                    .WithMany(b => b.NiveauMaitrises)
                    .HasForeignKey(b => b.UserFk);
            modelBuilder.Entity<NiveauMaitrise>()
                    .HasOne(a => a.Language)
                    .WithMany(b => b.NiveauMaitrises)
                    .HasForeignKey(b => b.LangageFk);

            modelBuilder.Entity<NiveauMaitrise>().HasKey(f => new
            {

                f.UserFk,
                f.LangageFk
            });*/

            /*modelBuilder.Entity<EntretienRH>()
                    .HasOne(a => a.TypePersonnel)
                    .WithOne(b => b.Administrateur)
                    .HasForeignKey<TypePersonnel>(b => b.Libelle);*/

            /*modelBuilder.Entity<NiveauMaitrise>()
                    .HasOne(a => a.TypePersonnel)
                    .WithOne(b => b.Administrateur)
                    .HasForeignKey<TypePersonnel>(b => b.Libelle);*/

            /*modelBuilder.Entity<TestTechnique>()
                    .HasOne(a => a.TypePersonnel)
                    .WithOne(b => b.Administrateur)
                    .HasForeignKey<TypePersonnel>(b => b.Libelle);*/

        }
    }
}
