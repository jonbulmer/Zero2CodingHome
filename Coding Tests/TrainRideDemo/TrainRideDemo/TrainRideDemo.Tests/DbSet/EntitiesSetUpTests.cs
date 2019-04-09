using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainRideDemo.Data;
using Microsoft.EntityFrameworkCore;
using TrainDemo.Domain.Service;
using TrainDemo.Domain;
using System;

namespace TrainRideDemo.Tests.DbSet
{
    [TestFixture]
    class EntitiesSetUpTests
    {
        [Test]
        public void ArrivalTime_Adds_One_Full_Object()
        {
            var mockArrivalTimeDbSet = Substitute.For<DbSet<ArrivalTime>>();
            var mockTrainRideContext = Substitute.For<IScheduleDbContext>();
            mockTrainRideContext.ArrivalTimes.Returns(mockArrivalTimeDbSet);

            mockArrivalTimeDbSet.Add(new ArrivalTime { Id = 1, StopPositionOnRouteId = 1, TimeArrived = DateTime.Parse("1/1/1990 12:00") });

            mockArrivalTimeDbSet.Received(1).Add(Arg.Any<ArrivalTime>());
        }

        [Test]
        public void Routes_Adds_One_Full_Object()
        {
            var mockRouteDbSet = Substitute.For<DbSet<Route>>();
            var mockTrainRideContext = Substitute.For<IScheduleDbContext>();
            mockTrainRideContext.Routes.Returns(mockRouteDbSet);

            mockRouteDbSet.Add(new Route { Id = 1, Name= "Test" });

            mockRouteDbSet.Received(1).Add(Arg.Any<Route>());
        }

        [Test]
        public void StopProximities_Adds_One_Full_Object()
        {
            var mockStopProximityDbSet = Substitute.For<DbSet<StopProximity>>();
            var MockTrainRideContext = Substitute.For<IScheduleDbContext>();
            MockTrainRideContext.StopProximities.Returns(mockStopProximityDbSet);

            mockStopProximityDbSet.Add(new StopProximity { Id = 1, StopId = 1 });

            mockStopProximityDbSet.Received(1).Add(Arg.Any<StopProximity>());
        }

        [Test]
        public void StopPositionOnRoutes_Adds_One_Full_Object()
        {
            var mockStopPositionOnRouteDbSet = Substitute.For<DbSet<StopPositionOnRoute>>();
            var mockTrainRideContext = Substitute.For<IScheduleDbContext>();
            mockTrainRideContext.StopPositionOnRoutes.Returns(mockStopPositionOnRouteDbSet);

            mockStopPositionOnRouteDbSet.Add(new StopPositionOnRoute { Id = 1,  ExpectedRelativeArrivalTime = 1.1M , PositionIndex = 1, RouteId = 1, StopProximityId = 1 });

            mockStopPositionOnRouteDbSet.Received(1).Add(Arg.Any<StopPositionOnRoute>());
        }

        [Test]
        public void Stops_Adds_One_Full_Object()
        {
            var mockStopDbSet = Substitute.For<DbSet<Stop>>();
            var mockTrainRideContext = Substitute.For<IScheduleDbContext>();
            mockTrainRideContext.Stops.Returns(mockStopDbSet);

            mockStopDbSet.Add(new Stop { Id = 1, Latitued =  1.1M, Longitued = 1.1M, Name = "Test" });

            mockStopDbSet.Received(1).Add(Arg.Any<Stop>());
        }

        [Test]
        public void SetOffTimes_Adds_One_Full_Object()
        {
            var mockSetOffTimeDbSet = Substitute.For<DbSet<SetOffTime>>();
            var mockTrainRideContext = Substitute.For<IScheduleDbContext>();
            mockTrainRideContext.SetOffTimes.Returns(mockSetOffTimeDbSet);

            mockSetOffTimeDbSet.Add(new SetOffTime { Id = 1, RouteId = 1, StartStopTime = DateTime.Parse("1/1/1900 12:00"), TrainId = 1 });

            mockSetOffTimeDbSet.Received(1).Add(Arg.Any<SetOffTime>());
        }
    }
}

