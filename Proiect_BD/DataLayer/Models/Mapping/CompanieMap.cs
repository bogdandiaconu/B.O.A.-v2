using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class CompanieMap : EntityTypeConfiguration<Companie>
    {
        public CompanieMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Companie);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Companie");
            this.Property(t => t.ID_Companie).HasColumnName("ID_Companie");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.ID_Comandant).HasColumnName("ID_Comandant");
            this.Property(t => t.ID_Administrator).HasColumnName("ID_Administrator");

            // Relationships
            this.HasRequired(t => t.Administratori)
                .WithMany(t => t.Companies)
                .HasForeignKey(d => d.ID_Administrator);
            this.HasRequired(t => t.CDT_Comp)
                .WithMany(t => t.Companies)
                .HasForeignKey(d => d.ID_Comandant);

        }
    }
}
