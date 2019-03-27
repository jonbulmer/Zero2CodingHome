using Microsoft.EntityFrameworkCore;
using System;
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

        public DbSet<Stop> Stop { get; set; }
        public DbSet<StopProximity> StopProximities { get; set; }
        public DbSet<StopMaxtrix> StopMaxtrixs { get; set; }
        public DbSet<Stop> Stops { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
