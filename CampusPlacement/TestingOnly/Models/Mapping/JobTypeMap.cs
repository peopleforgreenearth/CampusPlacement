using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TestingOnly.Models.Mapping
{
    public class JobTypeMap : EntityTypeConfiguration<JobType>
    {
        public JobTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.JobTypeID);

            // Properties
            this.Property(t => t.JobTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JobTypes");
            this.Property(t => t.JobTypeID).HasColumnName("JobTypeID");
            this.Property(t => t.JobTypeName).HasColumnName("JobTypeName");
        }
    }
}
