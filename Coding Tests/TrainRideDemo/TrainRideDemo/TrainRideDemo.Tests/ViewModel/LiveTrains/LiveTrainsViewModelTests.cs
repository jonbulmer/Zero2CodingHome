using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainRideDemo.Data;
using Microsoft.EntityFrameworkCore;
using TrainDemo.Domain.Service;
using TrainRideDemo.Domain.Tests.TestUtils;

namespace TrainRideDemo.Tests
{
    [TestFixture]
    public class LiveTrainsViewModelTests
    {
        [Test]
        public void Get_StopMaxrix_Record()
        {
            //Arrange
            var mockSetStopPositionOnRouteDbSet = Substitute.For<DbSet<StopPositionOnRoute>>();
            var MockTrainRideContext = Substitute.For<IScheduleDbContext>();
            //MockTrainRideContext.StopPositionOnRoutes.Returns(mockSetStopPositionOnRouteDbSet);
            mockSetStopPositionOnRouteDbSet.Add(new StopPositionOnRoute { Id = 1, PositionIndex = 1, RouteId = 1, StopProximityId = 1 });
            MockTrainRideContext.StopPositionOnRoutes.Returns(mockSetStopPositionOnRouteDbSet);
            ///////var service = new LiveTrainsService(mockContext);
            //Act

            //service.Add(new LiveTrainsViewModel { TrainName= "Test" , RouteName = "Big Test"  });

            // Assert
            
            mockSetStopPositionOnRouteDbSet.Received(1).Add(Arg.Any<StopPositionOnRoute>());
            
        }

        [Test]
        public void NsubWIP()
        {
            var stopData = new List<Stop>
            {
                new Stop { Id= 1 , Name = "Darlington", Latitude = 1.1M , Longitude = 1.1M  }
            };

            var stopProximityData = new List<StopProximity>
            {
                new StopProximity { Id= 1 , StopId = 1  }
            };

            
            var mockStopSet = DbSetMockUtils.CreateMockDbSet(stopData);

            var mockStopProximitySet = DbSetMockUtils.CreateMockDbSet(stopProximityData);

            // do the wiring between DbContext and DbSet
            var mockContext = Substitute.For<IScheduleDbContext>();
            mockContext.Stops.Returns(mockStopSet);
            mockContext.StopProximities.Returns(mockStopProximitySet);
            var service = new LiveTrainsService(mockContext);
            //// Act
            var getStops = service.GetAllStops();

            //// Assert
            Assert.That(getStops.Count, Is.EqualTo(1));
            Assert.That(getStops.FirstOrDefault().Name  , Is.EqualTo("Darlington"));
        }

        [Test]
        public void TestSetExample()
        {
            var calculator = Substitute.For<ICalculator>();

            //calculator.Add(1, 2).Returns(3);
            Assert.That(calculator.Add(1, 2), Is.EqualTo(3));

            calculator.Received().Add(1, 2);
            calculator.DidNotReceive().Add(3, 7);

            calculator.Mode.Returns("DEC");
            Assert.That(calculator.Mode, Is.EqualTo("DEC"));


        }

    }
}
