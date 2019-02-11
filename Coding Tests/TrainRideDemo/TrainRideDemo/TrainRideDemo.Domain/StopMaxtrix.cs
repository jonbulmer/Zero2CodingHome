namespace TrainRideDemo.Domain
{
    public class StopMaxtrix
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public int StopProximityId { get; set; }
        public StopProximity StopProximity { get; set; }
        public int PositionIndex { get; set; }
    }
}
