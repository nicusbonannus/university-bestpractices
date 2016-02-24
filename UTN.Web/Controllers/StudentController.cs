using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UTN.Web.Models;

namespace UTN.Web.Controllers
{
    public class StudentController : Controller
    {
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