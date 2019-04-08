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

namespace TrainRideDemo.Tests
{
    [TestFixture]
    public class LiveTrainsViewModelTests
    {
        [Test]
        public void Get_StopMaxrix_Record()
        {
            //Arrange
            var mockSetStopMaxtrixDbSet = Substitute.For<DbSet<StopPositionOnRoute>>();
            var MockTrainRideContext = Substitute.For<IStopMaxtrixDbContext>();
            MockTrainRideContext.StopMaxtrixs.Returns(mockSetStopMaxtrixDbSet);
            mockSetStopMaxtrixDbSet.Add(new StopPositionOnRoute { Id = 1, PositionIndex = 1, RouteId = 1, StopProximityId = 1 });
            var service = new LiveTrainsService();
            //Act

            //service.Add(new LiveTrainsViewModel { TrainName= "Test" , RouteName = "Big Test"  });

            // Assert

            mockSetStopMaxtrixDbSet.Received(1).Add(Arg.Any<StopPositionOnRoute>());
           
        }

        [Test]
        public void TestSetExample()
        {
            var calculator = Substitute.For<ICalculator>();

            calculator.Add(1, 2).Returns(3);
            Assert.That(calculator.Add(1, 2), Is.EqualTo(3));

            calculator.Received().Add(1, 2);
            calculator.DidNotReceive().Add(3, 7);

            calculator.Mode.Returns("DEC");
            Assert.That(calculator.Mode, Is.EqualTo("DEC"));


        }

    }
}
