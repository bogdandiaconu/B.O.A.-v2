using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataLayer.Models.Mapping;

namespace DataLayer.Models
{
    public partial class ProiectBDContext : DbContext
    {
        static ProiectBDContext()
        {
            Database.SetInitializer<ProiectBDContext>(null);
        }

        public ProiectBDContext()
            : base("Name=ProiectBDContext")
        {
        }

        public DbSet<Administratori> Administratoris { get; set; }
        public DbSet<AlocareHrana> AlocareHranas { get; set; }
        public DbSet<ArticoleDrepturi> ArticoleDrepturis { get; set; }
        public DbSet<ArticoleVest> ArticoleVests { get; set; }
        public DbSet<CDT_Comp> CDT_Comp { get; set; }
        public DbSet<Companie> Companies { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Preturi> Preturis { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministratoriMap());
            modelBuilder.Configurations.Add(new AlocareHranaMap());
            modelBuilder.Configurations.Add(new ArticoleDrepturiMap());
            modelBuilder.Configurations.Add(new ArticoleVestMap());
            modelBuilder.Configurations.Add(new CDT_CompMap());
            modelBuilder.Configurations.Add(new CompanieMap());
            modelBuilder.Configurations.Add(new GradeMap());
            modelBuilder.Configurations.Add(new PreturiMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
