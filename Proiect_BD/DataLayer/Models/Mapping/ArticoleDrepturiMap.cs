using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class ArticoleDrepturiMap : EntityTypeConfiguration<ArticoleDrepturi>
    {
        public ArticoleDrepturiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_Student, t.ID_Administrator, t.Data_Alocarii });

            // Properties
            this.Property(t => t.ID_Student)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_Administrator)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ArticoleDrepturi");
            this.Property(t => t.ID_Student).HasColumnName("ID_Student");
            this.Property(t => t.ID_Administrator).HasColumnName("ID_Administrator");
            this.Property(t => t.Data_Alocarii).HasColumnName("Data_Alocarii");
            this.Property(t => t.Savoniera).HasColumnName("Savoniera");
            this.Property(t => t.Sapun).HasColumnName("Sapun");
            this.Property(t => t.Spuma_ras).HasColumnName("Spuma_ras");
            this.Property(t => t.Aparat_ras).HasColumnName("Aparat_ras");
            this.Property(t => t.Caiete).HasColumnName("Caiete");
            this.Property(t => t.Rigla).HasColumnName("Rigla");
            this.Property(t => t.Guma).HasColumnName("Guma");
            this.Property(t => t.Crema).HasColumnName("Crema");
            this.Property(t => t.Maieu).HasColumnName("Maieu");
            this.Property(t => t.Agrafe).HasColumnName("Agrafe");
            this.Property(t => t.Capse).HasColumnName("Capse");

            // Relationships
            this.HasRequired(t => t.Administratori)
                .WithMany(t => t.ArticoleDrepturis)
                .HasForeignKey(d => d.ID_Administrator);
            this.HasRequired(t => t.Student)
                .WithMany(t => t.ArticoleDrepturis)
                .HasForeignKey(d => d.ID_Student);

        }
    }
}
