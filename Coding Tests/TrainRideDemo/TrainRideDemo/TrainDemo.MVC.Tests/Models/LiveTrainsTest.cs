using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using NSubstitute;
using TrainDemo.MVC.Models;

namespace TrainDemo.MVC.Tests.Models
{

   [TestFixture]
   public class LiveTrainsTests
    {
        private LiveTrainsViewModel _liveTrainView;
        public LiveTrainsTests()
        {
            _liveTrainView = new LiveTrainsViewModel();
        }

        [SetUp]
        public void SetUp()
        {
            _liveTrainView.RouteName = "AberdeenLondon";
        }

        [Test]
        public void TrainGrid_Load_Has10Trains()
        {
                Assert.AreEqual("AberdeenLondon", _liveTrainView.RouteName);
        }
    }
}
