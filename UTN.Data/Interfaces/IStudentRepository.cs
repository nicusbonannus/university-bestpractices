using UTN.Data.Infraestructure;
using UTN.Models.DTO;

namespace UTN.Data.Interfaces
{
    public interface IStudentRepository : IRepository<StudentDTO>
    {
        StudentDTO GetByCode(int code);
    }
}
