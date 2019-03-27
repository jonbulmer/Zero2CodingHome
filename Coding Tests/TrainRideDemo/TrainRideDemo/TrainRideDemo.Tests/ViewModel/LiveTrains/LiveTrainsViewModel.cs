using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainRideDemo.Data;
using Microsoft.EntityFrameworkCore;
using TrainDemo.Domain.Service;

namespace TrainRideDemo.Tests.ViewModel.LiveTrains
{
    [TestFixture]
    public class LiveTrainsViewModelTests
    {
        [Test]
        public void GetAllLiveTrains_Returns_One_record()
        {
            var mockNewStopMaxtrixRideDbSet = Substitute.For<DbSet<StopMaxtrix>>();
            var MockTrainRideContext = Substitute.For<IStopMaxtrixDbContext>();
            MockTrainRideContext.StopMaxtrixs.Returns(mockNewStopMaxtrixRideDbSet);
            var service = new LiveTrainsService();
        }


    }
}
