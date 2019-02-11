using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Domain
{
    public class Stop
    {
        public Stop()
        {
            StopProximities = new List<StopProximity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<StopProximity> StopProximities { get; set; }
    }
}
