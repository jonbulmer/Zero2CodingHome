using System;
using System.Collections.Generic;
using System.Linq;
using TrainDemo.Domain.Service;
using System.Web.Mvc;

namespace TrainDemo.MVC.Controllers
{
    public class TrainDashboardController : Controller
    {

        readonly ILiveTrainsService trainDash;
        public TrainDashboardController(ILiveTrainsService trainDashRepo)
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