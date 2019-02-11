using Microsoft.EntityFrameworkCore;
using TrainRideDemo.Domain;

namespace TrainRideDemo.Data
{
    public class TrainRideDemo : DbContext
    {
        public DbSet<Stop> Stop { get; set; }
        public DbSet<StopProximity> StopProximities { get; set; }
        public DbSet<StopMaxtrix> StopMaxtrixs { get; set; }
    }
}
