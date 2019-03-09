using System;
using System.Collections.Generic;
using System.Linq;
using TrainDemo.MVC.Models;
using System.Web.Mvc;

namespace TrainDemo.MVC.Controllers
{
    public class TrainDashboardController : Controller
    {

        readonly ITrainDashboardDisplay trainDash;
        public TrainDashboardController(ITrainDashboardDisplay trainDashRepo)
        {
            trainDash = trainDashRepo;
        }
        public ActionResult Index()
        {
            var data = trainDash.GetAllLiveTrains();
            return View(data);
        }
    }
}