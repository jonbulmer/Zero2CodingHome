using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    public interface IStopPositionOnRoute
    {
        int Id { get; set; }
        int RouteId { get; set; }
        Route Route { get; set; }
        int PositionIndex { get; set; }
        int StopProximityId { get; set; }
        StopProximity StopProximity { get; set; }
        decimal ExpectedRelativeArrivalTime { get; set; }

    }
    public class StopPositionOnRoute : IStopPositionOnRoute
    {
        public ICollection<ArrivalTime> ArrivalTimes { get; set; }
        public StopPositionOnRoute()
        {
            ArrivalTimes = new HashSet<ArrivalTime>(); 
        }

        [Key]
        public int Id { get; set; }
        public int RouteId { get; set; }
        [ForeignKey("RouteId")]
        public Route Route { get; set; }
        public int PositionIndex { get; set; }
        public int StopProximityId { get; set; }
        [ForeignKey("StopProximityId")]
        public StopProximity StopProximity { get; set; }
        public decimal ExpectedRelativeArrivalTime { get; set; }
    }
}
