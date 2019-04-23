using System;
using System.Collections.Generic;
using TrainDemo.MVC.Controllers;
using NUnit.Framework;
using NSubstitute;
using TrainDemo.Domain.Service;
using System.Web.Mvc;

namespace TrainDemo.MVC.Tests
{
    [TestFixture]
    public class TrainDashboardControllerTest
    {

        /// <summary>
        /// Test the Action metjod returning Specific Index View
        /// </summary>
        [Test]
        public void TrainDashboad_Has_Index()
        {
            var mockTrainService = Substitute.For<ILiveTrainsService>();
            List<Domain.LiveTrainsViewModel> liveTrains = new List<Domain.LiveTrainsViewModel>();
            liveTrains.Add(new Domain.LiveTrainsViewModel { Id = 1, ArrivalTime = 12, RouteName = "Test", Station = "Test" });
            mockTrainService.GetAllDeparturesForStopByDay(1, DateTime.Parse("1/Apr/2019")).Returns(liveTrains);
            var obj = new TrainDashboardController(mockTrainService);

            var result = obj.Index() as ActionResult;


            //var redirectResult = (RedirectResult)result;

            var viewResult = (ViewResult)result;
            //int thisone = redirectResult.Url.Length;
            var thatone = viewResult.Model;
            //var model = Assert.IsAssignableFrom<IEnumerable<Domain.ILiveTrainsViewModel>>(actResult.ViewData.Model);
            //Assert.That(actResult.ToString(), Is.EqualTo("Index"));
        }

        [Test]
        public void LiveTrainsGrid_DisplaysAllTrainsOnKGX_EDG_OnTestDate()
        {

        }

    }
}
