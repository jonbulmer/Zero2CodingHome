using Microsoft.EntityFrameworkCore;
using TrainRideDemo.Domain;

namespace TrainRideDemo.Data
{
    public class StopContext : DbContext
    {
        public DbSet<Stop> Stops { get; set; }
    }
}
