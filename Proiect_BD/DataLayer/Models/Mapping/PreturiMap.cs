using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class PreturiMap : EntityTypeConfiguration<Preturi>
    {
        public PreturiMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Pret);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Preturi");
            this.Property(t => t.ID_Pret).HasColumnName("ID_Pret");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Pret).HasColumnName("Pret");
            this.Property(t => t.Data).HasColumnName("Data");
        }
    }
}
