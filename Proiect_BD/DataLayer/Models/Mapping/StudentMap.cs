using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models.Mapping
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Student);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Prenume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.CNP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(13);

            this.Property(t => t.Adresa)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Students");
            this.Property(t => t.ID_Student).HasColumnName("ID_Student");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
            this.Property(t => t.ID_Grad).HasColumnName("ID_Grad");
            this.Property(t => t.CNP).HasColumnName("CNP");
            this.Property(t => t.Adresa).HasColumnName("Adresa");
            this.Property(t => t.ID_Companie).HasColumnName("ID_Companie");

            // Relationships
            this.HasRequired(t => t.Companie)
                .WithMany(t => t.Students)
                .HasForeignKey(d => d.ID_Companie);
            this.HasRequired(t => t.Grade)
                .WithMany(t => t.Students)
                .HasForeignKey(d => d.ID_Grad);

        }
    }
}
