using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public class StopProximity
    {
        public int Id { get; set; }
        public Stop Stop { get; set; }
        public int StopId { get; set; }
    }
}
