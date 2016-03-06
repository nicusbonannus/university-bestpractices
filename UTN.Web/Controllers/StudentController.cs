using System.Web.Mvc;
using UTN.Service.Interfaces;
using UTN.Web.Models;

namespace UTN.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service) {
            _service = service;
        }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add() {
            return View();
        }

        public ActionResult Add(StudentViewModel student)
        {
            
            return View();

        }
    }
}