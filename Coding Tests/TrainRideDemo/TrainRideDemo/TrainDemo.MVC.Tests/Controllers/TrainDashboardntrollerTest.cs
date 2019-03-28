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
    public class TrainDashboardntrollerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            var service = new LiveTrainsService();
            TrainDashboardController controller = new TrainDashboardController(service);

            // Act
            ActionResult result = controller.Index() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
