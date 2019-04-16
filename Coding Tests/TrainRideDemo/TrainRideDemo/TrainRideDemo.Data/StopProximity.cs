using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public class StopProximity
    {
        public ICollection<StopPositionOnRoute> StopPositionOnRoutes { get; set; }
        public StopProximity()
        {
            StopPositionOnRoutes = new HashSet<StopPositionOnRoute>();
        }
        public int Id { get; set; }
        public int StopId { get; set; }
        public Stop Stop { get; set; }
        public int DestinationStopId { get; set; }
        public Stop DestinationStop { get; set; }
        public decimal Distance { get; set; }
        public decimal KPH { get; set; }
    }
}