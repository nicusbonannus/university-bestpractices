using System.Data.Entity.ModelConfiguration;
using UTN.Models.DTO;

namespace UTN.Data.Configuration
{
    public class CountryConfiguration : EntityTypeConfiguration<CountryDTO>
    {
        public CountryConfiguration() {
            ToTable("Countries");
            HasKey(primaryKey => primaryKey.CountryId);
            Property(field => field.Name).IsRequired().HasMaxLength(150);
        }   
    }
}
