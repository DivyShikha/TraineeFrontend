using System.Data;
using Microsoft.EntityFrameworkCore;

namespace WeatherForecast.Model
{
    public class TraineeContext : DbContext
    {
        public TraineeContext(DbContextOptions<TraineeContext> options) : base(options)
        { 
        }
        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
