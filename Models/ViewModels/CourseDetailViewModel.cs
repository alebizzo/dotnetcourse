using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcourse.Models.ViewModels
{
    public class CourseDetailViewModel : CourseViewModel
    {
        public string Course_Description { get; set; }
        public List<LessonViewModel> Course_Lessons { get; set; }
        public TimeSpan TotalCourseDuration { 
            get => TimeSpan.FromSeconds(Course_Lessons?.Sum(l => l.Lesson_Duration.TotalSeconds) ?? 0);
         }
    }
}