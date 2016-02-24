using System.Data.Entity.ModelConfiguration;
using UTN.Models.DTO;

namespace UTN.Data.Configuration
{
    public class StudentConfiguration : EntityTypeConfiguration<StudentDTO>
    {
        public StudentConfiguration() {
            ToTable("Students");
            HasKey(primaryKey => primaryKey.StudentId);
            Property(field => field.Code).IsRequired();
            Property(field => field.CountryId).IsRequired();
        }
    }
}
