using System.Collections.Generic;
using dotnetcourse.Models.ViewModels;

namespace dotnetcourse.Models.Services.Application
{
    public interface ICourseService
    {
         List<CourseViewModel> ListCourses();
         CourseDetailViewModel GetCourse(int id);
    }
}