using System.Linq;
using UTN.Data.Infraestructure;
using UTN.Data.Interfaces;
using UTN.Models.DTO;

namespace UTN.Data.Repositories
{
    public class StudentRepository : RepositoryBase<StudentDTO>, IStudentRepository
    {
        public StudentRepository(IDbFactory dbFactory): base(dbFactory) {

        }

        public StudentDTO GetByCode(int code)
        {
            return this.DbContext.Students.Where(student => student.Code == code).FirstOrDefault();
        }
    }
}
