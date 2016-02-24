using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using UTN.Data.Infraestructure;
using UTN.Data.Interfaces;
using UTN.Models.DTO;
using UTN.Service.Services;
using System.Linq;

namespace UTN.UnitTest
{
    [TestClass]
    public class StudentTest
    {
        private Mock<IStudentRepository> _mockRepository = new Mock<IStudentRepository>();

        [TestMethod]
        public void GetAllStudentsTest()
        {
            var returnListOfStudents = new List<StudentDTO>() {
                new StudentDTO() { Code = 1357748}
            };
            _mockRepository.Setup(method => method.GetAll()).Returns(returnListOfStudents);
            var service = new StudentService(_mockRepository.Object, new UnitOfWork(new DbFactory()));

            Assert.AreEqual(service.GetStudents().Count(), 1);
             
        }
    }
}
