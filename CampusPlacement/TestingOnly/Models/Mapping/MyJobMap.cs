using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TestingOnly.Models.Mapping
{
    public class MyJobMap : EntityTypeConfiguration<MyJob>
    {
        public MyJobMap()
        {
            // Primary Key
            this.HasKey(t => t.MyJobID);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MyJobs");
            this.Property(t => t.MyJobID).HasColumnName("MyJobID");
            this.Property(t => t.PostingID).HasColumnName("PostingID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
