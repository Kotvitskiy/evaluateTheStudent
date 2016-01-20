using AutoMapper;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBest.EntityProviders.Providers;
using TheBest.Models.Entities;

namespace TheBest.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult Index()
        {
            var student = new Student() { Name = "Тестовый", Group = "ПИ-99", IconUrl = "Content/Images/Students/arsen.jpg", Rate = 3, SocialUrl = "", Description="Очень, очень, очень хороший студент" };
            Site.Providers.StudentsProvider.Create(student);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Data()
        {
            var students = Site.Providers.StudentsProvider.GetAll();
            return Json(new { students = students });
        }

        [HttpPost]
        public ActionResult Rate(StudentViewModel student)
        {
            if(ModelState.IsValid)
            {
                var model = Mapper.Map<StudentViewModel, Student>(student);
                Site.Providers.StudentsProvider.Update(model);
                return Json(1);
            }
            return Json(0);
        }

        [HttpGet]
        public ActionResult List()
        {
            var students = Site.Providers.StudentsProvider.GetAll();

            var viewModel = Mapper.Map<List<Student>, List<StudentViewModel>>(students);

            return View(viewModel);              
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var student = Site.Providers.StudentsProvider.Get(id);
            var viewModel = Mapper.Map<Student, StudentViewModel>(student);
            return View(viewModel);
        }
    }
}