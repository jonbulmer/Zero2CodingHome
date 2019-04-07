using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    public interface IArrivalTime
    {
        int Id { get; set; }
        DateTime TimeArrived { get; set; }
        int StopPositionOnRouteId { get; set; }
        StopPositionOnRoute StopPositionOnRoute { get; set; }
    }

    public class ArrivalTime
    {
        public int Id { get; set; }
        public DateTime TimeArrived { get; set; }
        public int StopPositionOnRouteId { get; set; }
        [ForeignKey("StopPositionOnRouteId")]
        public StopPositionOnRoute StopPositionOnRoute { get; set; }
    }
}
