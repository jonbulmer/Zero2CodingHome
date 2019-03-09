using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using TrainRideDemo.Domain;
using Autofac;

namespace TrainRideDemo.Data
{
    public class TrainRideDemoContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
