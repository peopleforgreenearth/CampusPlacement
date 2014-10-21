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
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.TargetCity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ResumeText)
                .IsRequired();

            this.Property(t => t.CoverLetterText)
                .IsRequired();

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

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Resumes)
                .HasForeignKey(d => d.TargetCountryID);
            this.HasRequired(t => t.EducationLevel)
                .WithMany(t => t.Resumes)
                .HasForeignKey(d => d.EducationLevelID);
            this.HasRequired(t => t.ExperienceLevel)
                .WithMany(t => t.Resumes)
                .HasForeignKey(d => d.ExperienceLevelID);
            this.HasRequired(t => t.JobType)
                .WithMany(t => t.Resumes)
                .HasForeignKey(d => d.TargetJobTypeID);

        }
    }
}
