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
            var mockSetArrivalTimeDbSet = Substitute.For<DbSet<ArrivalTime>>();
            var MockTrainRideContext = Substitute.For<IScheduleDbContext>();
            MockTrainRideContext.ArrivalTimes.Returns(mockSetArrivalTimeDbSet);

            mockSetArrivalTimeDbSet.Add(new ArrivalTime { Id = 1, StopPositionOnRouteId = 1, TimeArrived = DateTime.Parse("1/1/1990 12:00") });

            mockSetArrivalTimeDbSet.Received(1).Add(Arg.Any<ArrivalTime>());
        }
    }
}

