using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace CampusPlacement.Models.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => t.CountryID);

            // Properties
            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Countries");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
        }
    }
}
