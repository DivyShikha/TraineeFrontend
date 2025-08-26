using System.ComponentModel.DataAnnotations;

namespace WeatherForecast.Model
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public String Phone { get; set; }
    }

}
