using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TestingOnly.Models.Mapping
{
    public class ExperienceLevelMap : EntityTypeConfiguration<ExperienceLevel>
    {
        public ExperienceLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.ExperienceLevelID);

            // Properties
            this.Property(t => t.ExperienceLevelName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ExperienceLevels");
            this.Property(t => t.ExperienceLevelID).HasColumnName("ExperienceLevelID");
            this.Property(t => t.ExperienceLevelName).HasColumnName("ExperienceLevelName");
        }
    }
}
