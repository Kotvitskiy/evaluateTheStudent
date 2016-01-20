using AutoMapper;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBest.Models.Entities;
using TheBest.Utils;

namespace TheBest.Areas.Admin.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult List()
        {
            var students = Site.Providers.StudentsProvider.GetAll();
            var model = Mapper.Map<List<Student>, List<StudentViewModel>>(students);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentViewModel model, HttpPostedFileBase imageFile)
        {

            var converter = ObjectManager.GetInstance<ImageConverter>();

            ConvertImage(imageFile, model.Name, 80, 80);
            ConvertImage(imageFile, model.Name, 166, 167, false);

            var student = Mapper.Map<StudentViewModel, Student>(model);

            UpdateModel(student, converter.BuildVirtualPath(model.Name, true), converter.BuildVirtualPath(model.Name, false)); 

            Site.Providers.StudentsProvider.Create(student);

            return RedirectToAction("List");
        }

        public ActionResult Update(string id)
        {
            var student = Site.Providers.StudentsProvider.Get(id);
            var model = Mapper.Map<Student, StudentViewModel>(student);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(StudentViewModel model)
        {
            var student = Mapper.Map<StudentViewModel, Student>(model);

            Site.Providers.StudentsProvider.Update(student);

            return RedirectToAction("List");
        }

        public void UpdateModel(Student student, string iconPath, string thumbnailPath)
        {
            student.Id = Guid.NewGuid().ToString();

            student.IconUrl = iconPath;

            student.ThumbnailUrl = thumbnailPath;
        }

        private void ConvertImage(HttpPostedFileBase image, string fileName, int width, int height, bool icon = true)
        {
            var converter = new ImageConverter();

            using (var tmp = converter.GetImageFromFile(image))
            {
                var resizedImage = converter.ResizeImage(tmp, width, width);
                converter.SaveImage(resizedImage, fileName, icon);
            }
        }

    }
}