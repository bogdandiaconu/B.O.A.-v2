using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models.Mapping
{
    public class AlocareHranaMap : EntityTypeConfiguration<AlocareHrana>
    {
        public AlocareHranaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_Student, t.ID_Pret });

            // Properties
            this.Property(t => t.ID_Student)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_Pret)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AlocareHrana");
            this.Property(t => t.ID_Student).HasColumnName("ID_Student");
            this.Property(t => t.ID_Pret).HasColumnName("ID_Pret");
            this.Property(t => t.ID_Administrator).HasColumnName("ID_Administrator");
            this.Property(t => t.Counter).HasColumnName("Counter");

            // Relationships
            this.HasRequired(t => t.Administratori)
                .WithMany(t => t.AlocareHranas)
                .HasForeignKey(d => d.ID_Administrator);
            this.HasRequired(t => t.Preturi)
                .WithMany(t => t.AlocareHranas)
                .HasForeignKey(d => d.ID_Pret);
            this.HasRequired(t => t.Student)
                .WithMany(t => t.AlocareHranas)
                .HasForeignKey(d => d.ID_Student);

        }
    }
}
