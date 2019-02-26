using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Domain
{
    public class TimeTable
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public List<Route> Route { get; set; }
        public string Name { get; set; }
        public DateTime StopTime { get; set; }
        public int TrainId { get; set; }
        public List<Train> Train { get; set; }
    }
}
