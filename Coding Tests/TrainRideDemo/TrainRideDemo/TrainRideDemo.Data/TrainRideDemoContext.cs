using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;
using Autofac;

namespace TrainRideDemo.Data
{
    public interface IStopMaxtrixDbContext
    {
        DbSet<StopMaxtrix> StopMaxtrixs { get; set; }
    }

    public class TrainRideDemoContext : DbContext, IStopMaxtrixDbContext
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
        public virtual DbSet<StopMaxtrix> StopMaxtrixs { get; set; }
        public virtual DbSet<Stop> Stops { get; set; }
        public virtual DbSet<TimeTable> TimeTables { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Conventions.Remove<PluralizingTableNameConvention>();

            builder.Entity<StopMaxtrix>(entity =>
            {
                entity.HasOne(d => d.StopProximity)
                .WithMany(p => p.StopMaxtrixs)
                .HasForeignKey(d => d.StopProximityId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        
                entity.HasOne(d => d.Route)
                .WithMany(p => p.StopMaxtrixs)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            builder.Entity<ArrivalTime>(entity =>
            {
                entity.HasOne(d => d.StopMaxtrix)
                .WithMany(p => p.ArrivalTimes)
                .HasForeignKey(d => d.StopMaxtrixId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
