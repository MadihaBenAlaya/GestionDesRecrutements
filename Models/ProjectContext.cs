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
        public DbSet<Departement> Departements { get; set; }
        


            
        
    }
}
