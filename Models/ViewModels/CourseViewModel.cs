using dotnetcourse.Models.ValueTypes;

namespace dotnetcourse.Models.ViewModels
{
    public class CourseViewModel
    {
        public int Course_Id { get; set; }
        public string Course_Title { get; set; }
        public string Course_Image { get; set; }
        public string Course_Author { get; set; }
        public double Course_Rating { get; set; }
        public Money Course_Price_List { get; set; }
        public Money Course_Price { get; set; }
    }
}