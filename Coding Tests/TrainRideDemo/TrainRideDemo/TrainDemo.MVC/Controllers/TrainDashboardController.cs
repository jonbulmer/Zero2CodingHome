using System;
using System.Collections.Generic;
using System.Linq;
using TrainDemo.Domain.Service;
using System.Web.Mvc;

namespace TrainDemo.MVC.Controllers
{
    public class TrainDashboardController : Controller
    {

        readonly ILiveTrainsService _trainService;
        public TrainDashboardController(ILiveTrainsService trainService)
        {
            _trainService = trainService;
        }
        public ActionResult Index()
        {
            var liveTest = _trainService.GetAllStops();
            var data = _trainService.GetAllDeparturesForStopByDay(1,DateTime.Parse("1/Apr/2019"));

            return View(data);
        }
    }
}