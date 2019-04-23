using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;
using Autofac;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public interface IScheduleDbContext
    {
        DbSet<ArrivalTime> ArrivalTimes { get; set; }
        DbSet<Route> Routes { get; set; }
        DbSet<StopProximity> StopProximities { get; set; }
        DbSet<StopPositionOnRoute> StopPositionOnRoutes { get; set; }
        DbSet<Stop> Stops { get; set; }
        DbSet<SetOffTime> SetOffTimes { get; set; }
        Task<int> SaveChangesAsync();

    }

    public class ScheduleContext : DbContext, IScheduleDbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["TrainRideDemoContext"].ConnectionString);
        }

        public virtual DbSet<ArrivalTime> ArrivalTimes { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<StopProximity> StopProximities { get; set; }
        public virtual DbSet<StopPositionOnRoute> StopPositionOnRoutes { get; set; }
        public virtual DbSet<Stop> Stops { get; set; }
        public virtual DbSet<SetOffTime> SetOffTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StopPositionOnRoute>(entity =>
            {
                entity.HasOne(d => d.StopProximity)
                .WithMany(p => p.StopPositionOnRoutes)
                .HasForeignKey(d => d.StopProximityId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        
                entity.HasOne(d => d.Route)
                .WithMany(p => p.StopPositionOnRoutes)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            builder.Entity<ArrivalTime>(entity =>
            {
                entity.HasOne(d => d.StopPositionOnRoute)
                .WithMany(p => p.ArrivalTimes)
                .HasForeignKey(d => d.StopPositionOnRouteId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            builder.Entity<StopProximity>(entity =>
            {
                entity.HasOne(d => d.Stop)
                .WithMany(p => p.StopProximities)
                .HasForeignKey(d => d.StopId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }

        public Task<int> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
