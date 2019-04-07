using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;
using Autofac;

namespace TrainRideDemo.Data
{
    public interface IStopMaxtrixDbContext
    {
        DbSet<StopPositionOnRoute> StopMaxtrixs { get; set; }
    }

    public class TrainRideDemoContext : DbContext//, IStopMaxtrixDbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["TrainRideDemoContext"].ConnectionString);
        }

        public static TrainRideDemoContext Create()
        {
            return new TrainRideDemoContext();
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
        }
    }
}
