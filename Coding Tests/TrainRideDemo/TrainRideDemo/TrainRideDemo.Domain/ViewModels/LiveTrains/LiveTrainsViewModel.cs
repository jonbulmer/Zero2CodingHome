using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainRideDemo.Data;

namespace TrainDemo.Domain
{
    public interface ILiveTrainsViewModel
    {
        int Id { get; set; }
        string TrainName { get; set; }
        string RouteName { get; set; }
        List<SetOffTime> TimeTable { get; set; }
    }

    public class LiveTrainsViewModel : ILiveTrainsViewModel
    {
        public int Id { get; set; }
        public string TrainName { get; set; }
        public string RouteName { get; set; }
        public List<SetOffTime> TimeTable { get; set; }
        public List<StopPositionOnRoute> StopMaxtrix { get; set; }
        public List<ArrivalTime> ArrivalTime { get; set; }
    }

   
}