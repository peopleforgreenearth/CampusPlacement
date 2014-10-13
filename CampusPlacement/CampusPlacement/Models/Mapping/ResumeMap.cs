using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace CampusPlacement.Models.Mapping
{
    public class ResumeMap : EntityTypeConfiguration<Resume>
    {
        public ResumeMap()
        {
            // Primary Key
            this.HasKey(t => t.ResumeID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.JobTitle)
                .HasMaxLength(255);

            this.Property(t => t.TargetCity)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Resumes");
            this.Property(t => t.ResumeID).HasColumnName("ResumeID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
            this.Property(t => t.TargetCity).HasColumnName("TargetCity");
            this.Property(t => t.TargetStateID).HasColumnName("TargetStateID");
            this.Property(t => t.TargetCountryID).HasColumnName("TargetCountryID");
            this.Property(t => t.RelocationCountryID).HasColumnName("RelocationCountryID");
            this.Property(t => t.TargetJobTypeID).HasColumnName("TargetJobTypeID");
            this.Property(t => t.EducationLevelID).HasColumnName("EducationLevelID");
            this.Property(t => t.ExperienceLevelID).HasColumnName("ExperienceLevelID");
            this.Property(t => t.ResumeText).HasColumnName("ResumeText");
            this.Property(t => t.CoverLetterText).HasColumnName("CoverLetterText");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.SubcategoryID).HasColumnName("SubcategoryID");
            this.Property(t => t.PostDate).HasColumnName("PostDate");
        }
    }
}
