using System;
using System.Collections.Generic;
using dotnetcourse.Models.ViewModels;

namespace dotnetcourse.Models.Services.Application
{
    public class CourseService : ICourseService
    {
        public List<CourseViewModel> ListCourses()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel
                {
                    Course_Id = i,
                    Course_Title = $"Corso {i}",
                    Course_Author = "Nome e Cognome",
                    Course_Image = "http://placeimg.com/50/50/any",
                    Course_Price_List = new ValueTypes.Money(rand.NextDouble() > 0.5 ? price : price -1, ValueTypes.Currency.Eur),
                    Course_Price = price,
                    Course_Rating = rand.NextDouble() * 5.0
                };
                courseList.Add(course);
            }
            return courseList;
        }

        public CourseDetailViewModel GetCourse(int id)
        {
            var rand = new Random();
            var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            var course = new CourseDetailViewModel
            {
                    Course_Id = id,
                    Course_Title = $"Corso {id}",
                    Course_Author = "Nome e Cognome",
                    Course_Image = "http://placeimg.com/50/50/any",
                    Course_Price = new ValueTypes.Money(rand.NextDouble() > 0.5 ? price : price -1, ValueTypes.Currency.Eur),
                    Course_Price_List = price,
                    Course_Rating = rand.NextDouble() * 5.0,
                    Course_Description = $"Descrizione {id}",
                    Course_Lessons = new List<LessonViewModel>()
            };
            for (int i = 0; i < 5; i++)
            {
                var Lesson = new LessonViewModel
                {
                    Lesson_Title = $"Titolo {i}",
                    Lesson_Duration = TimeSpan.FromSeconds(rand.Next(40, 90))
                };
                course.Course_Lessons.Add(Lesson);
            }
            return course;
        }

    }
}