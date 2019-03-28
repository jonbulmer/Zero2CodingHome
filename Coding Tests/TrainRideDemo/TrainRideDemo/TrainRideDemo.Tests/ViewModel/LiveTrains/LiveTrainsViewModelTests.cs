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
            var mockSetStopMaxtrixRideDbSet = Substitute.For<DbSet<StopMaxtrix>>();
            var MockTrainRideContext = Substitute.For<IStopMaxtrixDbContext>();
            MockTrainRideContext.StopMaxtrixs.Returns(mockSetStopMaxtrixRideDbSet);
            var service = new LiveTrainsService();
            //Act

            service.Add(new LiveTrainsViewModel { TrainName= "Test" , RouteName = "Big Test"  });

            // Assert

            mockSetStopMaxtrixRideDbSet.Received(1).Add(Arg.Any<StopMaxtrix>());
        }


    }
}
