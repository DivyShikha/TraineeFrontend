using System.Data;
using Microsoft.EntityFrameworkCore;
using WeatherForecast.Model;

namespace WeatherForecast.Data
{
    public class TraineeContext : DbContext
    {
        public TraineeContext(DbContextOptions<TraineeContext> options) : base(options)
        { 
        }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
