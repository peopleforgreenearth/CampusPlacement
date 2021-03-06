using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TestingOnly.Models.Mapping
{
    public class EducationLevelMap : EntityTypeConfiguration<EducationLevel>
    {
        public EducationLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.EducationLevelID);

            // Properties
            this.Property(t => t.EducationLevelName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EducationLevels");
            this.Property(t => t.EducationLevelID).HasColumnName("EducationLevelID");
            this.Property(t => t.EducationLevelName).HasColumnName("EducationLevelName");
        }
    }
}
