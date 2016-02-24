using System.Collections.Generic;
using UTN.Models.DTO;

namespace UTN.Service.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetStudents();
        StudentDTO GetStudent(int id);
        void CreateStudent(StudentDTO student);
        void SaveStudent();
    }
}
