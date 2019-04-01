using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    public interface IStopMaxtrix
    {
        int Id { get; set; }
        int RouteId { get; set; }
        Route Route { get; set; }
        int PositionIndex { get; set; }
        int StopProximityId { get; set; }
        StopProximity StopProximity { get; set; }
    }
    public class StopMaxtrix : IStopMaxtrix
    {
        public ICollection<ArrivalTime> ArrivalTimes { get; set; }
        public StopMaxtrix()
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
    }
}
