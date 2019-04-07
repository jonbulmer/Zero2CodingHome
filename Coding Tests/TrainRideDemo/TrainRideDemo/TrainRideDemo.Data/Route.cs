using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public class Route
    {
        public Route()
        {
            StopPositionOnRoutes = new HashSet<StopPositionOnRoute>();
            SetOffTimes = new HashSet<SetOffTime>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StopPositionOnRoute> StopPositionOnRoutes { get; set; }
        public ICollection<SetOffTime> SetOffTimes { get; set; }

    }
}
