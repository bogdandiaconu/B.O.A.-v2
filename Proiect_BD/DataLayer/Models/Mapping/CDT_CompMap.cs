using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class CDT_CompMap : EntityTypeConfiguration<CDT_Comp>
    {
        public CDT_CompMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Comandant);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.Prenume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("CDT_Comp");
            this.Property(t => t.ID_Comandant).HasColumnName("ID_Comandant");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
            this.Property(t => t.ID_Grad).HasColumnName("ID_Grad");

            // Relationships
            this.HasRequired(t => t.Grade)
                .WithMany(t => t.CDT_Comp)
                .HasForeignKey(d => d.ID_Grad);

        }
    }
}
