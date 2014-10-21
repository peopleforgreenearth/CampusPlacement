using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace CampusPlacement.Models.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateID);

            // Properties
            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("States");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.StateName).HasColumnName("StateName");
        }
    }
}
