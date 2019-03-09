using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainRideDemo.Domain;

namespace TrainDemo.MVC.Models
{
    public interface ILiveTrainsViewModel
    {
        int Id { get; set; }
        string TrainName { get; set; }
        string RouteName { get; set; }
        List<TimeTable> TimeTable { get; set; }
    }

    public class LiveTrainsViewModel : ILiveTrainsViewModel
    {
        public int Id { get; set; }
        public string TrainName { get; set; }
        public string RouteName { get; set; }
        public List<TimeTable> TimeTable { get; set; }
        public List<StopsDetails> StopsDetails { get; set; }
        public List<ArrivalTime> ArrivalTime { get; set; }
    }

   
}