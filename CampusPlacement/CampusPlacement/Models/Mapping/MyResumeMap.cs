using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class MyResumeMap : EntityTypeConfiguration<MyResume>
    {
        public MyResumeMap()
        {
            // Primary Key
            this.HasKey(t => t.MyResumeID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MyResumes");
            this.Property(t => t.MyResumeID).HasColumnName("MyResumeID");
            this.Property(t => t.ResumeID).HasColumnName("ResumeID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
