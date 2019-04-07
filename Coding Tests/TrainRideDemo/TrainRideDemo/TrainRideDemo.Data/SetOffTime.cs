using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    public interface ISetOffTime
    {
        int Id { get; set; }
        int RouteId { get; set; }
        Route Route { get; set; }
        DateTime StartStopTime { get; set; }
        int TrainId { get; set; }
        Train Train { get; set; }
    }

    public class SetOffTime : ISetOffTime
    {
        [Key]
        public int Id { get; set; }
        public int RouteId { get; set; }
        [ForeignKey("RouteId")]
        public Route Route { get; set; }
        public DateTime StartStopTime { get; set; }
        public int TrainId { get; set; }
        public Train Train { get; set; }
    }
}
