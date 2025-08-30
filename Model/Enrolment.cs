using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;

namespace WeatherForecast.Model
{
    public class Enrolment
    {
        [Key]
        public int EnrollmentID { get; set; }
        [Required]
        public String Description { get; set; }

        public int CourseID { get; set; }
        public int TraineeID { get; set; }

        public Course? Course { get; set; }
        public Trainee? Trainee { get; set; }

    }
}
