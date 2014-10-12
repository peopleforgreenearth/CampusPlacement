using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(255);

            this.Property(t => t.Address1)
                .HasMaxLength(255);

            this.Property(t => t.Address2)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Zip)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.CompanyEmail)
                .HasMaxLength(255);

            this.Property(t => t.WebSiteUrl)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Companies");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.CompanyEmail).HasColumnName("CompanyEmail");
            this.Property(t => t.WebSiteUrl).HasColumnName("WebSiteUrl");
            this.Property(t => t.CompanyProfile).HasColumnName("CompanyProfile");
        }
    }
}
