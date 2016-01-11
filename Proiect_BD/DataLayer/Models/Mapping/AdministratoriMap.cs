using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class AdministratoriMap : EntityTypeConfiguration<Administratori>
    {
        public AdministratoriMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Admistrator);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Prenume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Administratori");
            this.Property(t => t.ID_Admistrator).HasColumnName("ID_Admistrator");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
            this.Property(t => t.ID_Grad).HasColumnName("ID_Grad");

            // Relationships
            this.HasRequired(t => t.Grade)
                .WithMany(t => t.Administratoris)
                .HasForeignKey(d => d.ID_Grad);

        }
    }
}
