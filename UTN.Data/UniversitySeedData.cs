using System.Collections.Generic;
using System.Data.Entity;
using UTN.Models.DTO;

namespace UTN.Data
{
    public class UniversitySeedData : DropCreateDatabaseIfModelChanges<UTNEntities>
    {
        protected override void Seed(UTNEntities context)
        {
            GetCountries().ForEach(country => context.Countries.Add(country));
            GetStudents().ForEach(student => context.Students.Add(student));
            context.Commit();
        }

        private static List<CountryDTO> GetCountries() {
            return new List<CountryDTO>() {
                new CountryDTO() {
                    Name = "Argentina"
                },
                new CountryDTO() {
                    Name = "Brasil"
                },
                new CountryDTO() {
                    Name = "Chile"
                },
                new CountryDTO() {
                    Name = "Uruguay"
                },
                new CountryDTO() {
                    Name = "Venezuela"
                },
                new CountryDTO() {
                    Name = "Paraguay"
                },
                new CountryDTO() {
                    Name = "Bolivia"
                },
                new CountryDTO() {
                    Name = "Peru"
                },
            };
        }

        private static List<StudentDTO> GetStudents(){
            return new List<StudentDTO>()
            {
                new StudentDTO() {
                    Code = 1232131,
                    CountryId = 1
                },
                new StudentDTO() {
                    Code = 23213,
                    CountryId = 2
                }
            };
        } 
    }
}
