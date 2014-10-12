using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class JobPostingMap : EntityTypeConfiguration<JobPosting>
    {
        public JobPostingMap()
        {
            // Primary Key
            this.HasKey(t => t.PostingID);

            // Properties
            this.Property(t => t.ContactPerson)
                .HasMaxLength(255);

            this.Property(t => t.Title)
                .HasMaxLength(255);

            this.Property(t => t.Department)
                .HasMaxLength(50);

            this.Property(t => t.JobCode)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.PostedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JobPostings");
            this.Property(t => t.PostingID).HasColumnName("PostingID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.JobCode).HasColumnName("JobCode");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.EducationLevelID).HasColumnName("EducationLevelID");
            this.Property(t => t.JobTypeID).HasColumnName("JobTypeID");
            this.Property(t => t.MinSalary).HasColumnName("MinSalary");
            this.Property(t => t.MaxSalary).HasColumnName("MaxSalary");
            this.Property(t => t.JobDescription).HasColumnName("JobDescription");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.PostedBy).HasColumnName("PostedBy");
        }
    }
}
