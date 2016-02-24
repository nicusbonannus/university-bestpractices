using System.Web.Mvc;
using UTN.Service.Interfaces;

namespace UTN.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;

        public HomeController(IStudentService studentService) {
            _studentService = studentService;
        }
        // GET: Home
        public ActionResult Index()
        {
            var students = _studentService.GetStudents();
            return View();
        }
    }
}