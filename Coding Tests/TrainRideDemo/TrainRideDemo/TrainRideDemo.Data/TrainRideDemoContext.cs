using Microsoft.EntityFrameworkCore;
using TrainRideDemo.Domain;
using Autofac;

namespace TrainRideDemo.Data
{
    public class TrainRideDemoContext : DbContext
    {
        public static TrainRideDemoContext Create()
        {
            return new TrainRideDemoContext();
        }

        public DbSet<Stop> Stop { get; set; }
        public DbSet<StopProximity> StopProximities { get; set; }
        public DbSet<StopMaxtrix> StopMaxtrixs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
    }
}
