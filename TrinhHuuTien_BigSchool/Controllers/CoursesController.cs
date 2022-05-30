using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrinhHuuTien_BigSchool.Models;
using TrinhHuuTien_BigSchool.ViewModels;

namespace TrinhHuuTien_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        public readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}