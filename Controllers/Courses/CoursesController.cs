using System.Collections.Generic;
using dotnetcourse.Models.Services.Application;
using dotnetcourse.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcourse.Controllers.Courses
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;

        }
        public IActionResult Index()
        {

            // load courses
            List<CourseViewModel> courses = courseService.ListCourses();

            // return view
            return View(courses);
        }

        public IActionResult Detail(int id)
        {

            // load courses
            CourseDetailViewModel course = courseService.GetCourse(id);

            // set viewdata
            ViewData["Title"] = course.Course_Title;

            // return view
            return View(course);

        }

    }
}