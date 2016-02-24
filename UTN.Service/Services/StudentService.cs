using System;
using System.Collections.Generic;
using UTN.Data.Infraestructure;
using UTN.Data.Interfaces;
using UTN.Models.DTO;
using UTN.Service.Interfaces;

namespace UTN.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IStudentRepository studentRepository, IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
            _studentsRepository = studentRepository;
        }

        public void CreateStudent(StudentDTO student)
        {
            _studentsRepository.Add(student);
        }

        public StudentDTO GetStudent(int id)
        {
            return _studentsRepository.GetById(id);
        }

        public IEnumerable<StudentDTO> GetStudents()
        {
            return _studentsRepository.GetAll();
        }

        public void SaveStudent()
        {
            _unitOfWork.Commit();
        }
    }
}
