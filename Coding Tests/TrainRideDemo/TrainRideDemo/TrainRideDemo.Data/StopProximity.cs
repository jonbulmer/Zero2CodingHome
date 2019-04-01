using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public class StopProximity
    {
        public ICollection<StopMaxtrix> StopMaxtrixs { get; set; }
        public ICollection<Route> Routes { get; set; }
        public StopProximity()
        {
            StopMaxtrixs = new HashSet<StopMaxtrix>();
            Routes = new HashSet<Route>();
        }
        public int Id { get; set; }
        public int StopId { get; set; }
        public Stop Stop { get; set; }
    }
}
