using System.ComponentModel.DataAnnotations;

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
        [Key]
        public int Id { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public int PositionIndex { get; set; }
        public int StopProximityId { get; set; }
        public StopProximity StopProximity { get; set; }
    }
}
