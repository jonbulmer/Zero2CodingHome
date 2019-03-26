using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public interface ITimeTable
    {
        int Id { get; set; }
        int RouteId { get; set; }
        Route Route { get; set; }
        string Name { get; set; }
        DateTime StartStopTime { get; set; }
        int TrainId { get; set; }
        Train Train { get; set; }
    }

    public class TimeTable : ITimeTable
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public string Name { get; set; }
        public DateTime StartStopTime { get; set; }
        public int TrainId { get; set; }
        public Train Train { get; set; }
    }
}
