using System.ComponentModel.DataAnnotations;

namespace WeatherForecast.Model
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}
