using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTN.Web.Controllers;
using UTN.Service.Services;
using UTN.Service.Interfaces;
using UTN.Web.Models;
using System.Web;
using FakeHost;

namespace UTN.IntegrationTest
{
    [TestClass]
    public class StudentTests
    {
        private readonly IStudentService _service;
        public StudentTests() {
            //_service = new StudentService();
        }

        [TestMethod]
        public void AddStudentTest()
        {
            //var controller = new StudentController(_service);
            //var student = new StudentViewModel() {
            //      Code = 1357748,
            //      CountryId = 1
            //};
            //controller.Add(student);

        }
    }
}
