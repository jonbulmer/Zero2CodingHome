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
    }
}
