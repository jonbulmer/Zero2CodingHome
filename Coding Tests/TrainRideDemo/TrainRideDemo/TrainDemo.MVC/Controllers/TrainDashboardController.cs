using System;
using System.Collections.Generic;
using System.Linq;
using TrainDemo.Domain.Service;
using System.Web.Mvc;

namespace TrainDemo.MVC.Controllers
{
    public interface ITrainDashboardController
    {
        ActionResult Index();
    }
    public class TrainDashboardController : Controller , ITrainDashboardController
    {

        readonly ILiveTrainsService _trainService;
        public TrainDashboardController(ILiveTrainsService trainService)
        {
            _trainService = trainService;
        }
        public ActionResult Index()
        {
            var data = _trainService.GetAllDeparturesForStopByDay(1,DateTime.Parse("1/Apr/2019"));

            return View(data);
        }
    }
}