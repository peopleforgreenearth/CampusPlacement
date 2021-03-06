using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TestingOnly.Models.Mapping
{
    public class MySearchMap : EntityTypeConfiguration<MySearch>
    {
        public MySearchMap()
        {
            // Primary Key
            this.HasKey(t => t.MySearchID);

            // Properties
            this.Property(t => t.SearchCriteria)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MySearches");
            this.Property(t => t.MySearchID).HasColumnName("MySearchID");
            this.Property(t => t.SearchCriteria).HasColumnName("SearchCriteria");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.PostDate).HasColumnName("PostDate");
        }
    }
}
