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

            //// create a mock DbSet exposing both DbSet and IQueryable interfaces for setup
            //var mockSet = Substitute.For<DbSet<Person>, IQueryable<Person>>();

            //// setup all IQueryable methods using what you have from "data"
            //((IQueryable<Person>)mockSet).Provider.Returns(data.Provider);
            //((IQueryable<Person>)mockSet).Expression.Returns(data.Expression);
            //((IQueryable<Person>)mockSet).ElementType.Returns(data.ElementType);
            //((IQueryable<Person>)mockSet).GetEnumerator().Returns(data.GetEnumerator());

            //// do the wiring between DbContext and DbSet
            //var mockContext = Substitute.For<IPeopleDbContext>();
            //mockContext.People.Returns(mockSet);
            //var service = new PeopleService(mockContext);

            //// Act
            //var people = service.GetAllPeople();

            //// Assert
            //Assert.That(people.Length, Is.EqualTo(3));
            //Assert.That(people[0].FirstName, Is.EqualTo("BBB"));
            //Assert.That(people[1].FirstName, Is.EqualTo("ZZZ"));
            //Assert.That(people[2].FirstName, Is.EqualTo("AAA"));

        }

        [Test]
        public void NsubWIP()
        {
            var data = new List<Stop>
            {
                new Stop { Id= 1 , Name = "Darlington", Latitued = 1.1M , Longitued = 1.1M  }
            }.AsQueryable();

            // create a mock DbSet exposing both DbSet and IQueryable interfaces for setup
            var mockSet = Substitute.For<DbSet<Stop>, IQueryable<Stop>>();

            // setup all IQueryable methods using what you have from "data"
            ((IQueryable<Stop>)mockSet).Provider.Returns(data.Provider);
            ((IQueryable<Stop>)mockSet).Expression.Returns(data.Expression);
            ((IQueryable<Stop>)mockSet).ElementType.Returns(data.ElementType);
            ((IQueryable<Stop>)mockSet).GetEnumerator().Returns(data.GetEnumerator());

            // do the wiring between DbContext and DbSet
            var mockContext = Substitute.For<IScheduleDbContext>();
            mockContext.Stops.Returns(mockSet);
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

            calculator.Add(1, 2).Returns(3);
            Assert.That(calculator.Add(1, 2), Is.EqualTo(3));

            calculator.Received().Add(1, 2);
            calculator.DidNotReceive().Add(3, 7);

            calculator.Mode.Returns("DEC");
            Assert.That(calculator.Mode, Is.EqualTo("DEC"));


        }

    }
}
