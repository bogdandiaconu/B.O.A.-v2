using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class ArticoleVestMap : EntityTypeConfiguration<ArticoleVest>
    {
        public ArticoleVestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_Student, t.ID_Administrator, t.Data_Alocarii });

            // Properties
            this.Property(t => t.ID_Student)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID_Administrator)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ArticoleVest");
            this.Property(t => t.ID_Student).HasColumnName("ID_Student");
            this.Property(t => t.ID_Administrator).HasColumnName("ID_Administrator");
            this.Property(t => t.Data_Alocarii).HasColumnName("Data_Alocarii");
            this.Property(t => t.Bocanci).HasColumnName("Bocanci");
            this.Property(t => t.Capela).HasColumnName("Capela");
            this.Property(t => t.Cascheta).HasColumnName("Cascheta");
            this.Property(t => t.Costum_Camuflaj).HasColumnName("Costum_Camuflaj");
            this.Property(t => t.Costum_Tercot).HasColumnName("Costum_Tercot");
            this.Property(t => t.Costum_Camgarn).HasColumnName("Costum_Camgarn");
            this.Property(t => t.Camasa_Alba).HasColumnName("Camasa_Alba");
            this.Property(t => t.Camasa_Arma).HasColumnName("Camasa_Arma");
            this.Property(t => t.Camasa_Camuflaj).HasColumnName("Camasa_Camuflaj");
            this.Property(t => t.Boneta).HasColumnName("Boneta");
            this.Property(t => t.Fular).HasColumnName("Fular");
            this.Property(t => t.Pantofi).HasColumnName("Pantofi");
            this.Property(t => t.Ghete).HasColumnName("Ghete");
            this.Property(t => t.Ecuson_Nominal).HasColumnName("Ecuson_Nominal");
            this.Property(t => t.Ecuson_Romania).HasColumnName("Ecuson_Romania");
            this.Property(t => t.Cuc).HasColumnName("Cuc");
            this.Property(t => t.Cravata).HasColumnName("Cravata");
            this.Property(t => t.Scurta_Oras).HasColumnName("Scurta_Oras");
            this.Property(t => t.Scurta_Camuflat).HasColumnName("Scurta_Camuflat");

            // Relationships
            this.HasRequired(t => t.Administratori)
                .WithMany(t => t.ArticoleVests)
                .HasForeignKey(d => d.ID_Administrator);
            this.HasRequired(t => t.Student)
                .WithMany(t => t.ArticoleVests)
                .HasForeignKey(d => d.ID_Student);

        }
    }
}
