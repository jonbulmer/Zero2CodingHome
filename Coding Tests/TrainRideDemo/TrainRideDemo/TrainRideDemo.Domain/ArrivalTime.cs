using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Domain
{
    public class ArrivalTime
    {
        public int Id { get; set; }
        public DateTime TimeArrived { get; set; }
        public StopMaxtrix StopMaxtrix { get; set; }
        public int StopMaxtrixId { get; set; }

    }
}
