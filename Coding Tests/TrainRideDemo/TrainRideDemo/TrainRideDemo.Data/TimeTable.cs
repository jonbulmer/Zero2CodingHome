using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    public interface ITimeTable
    {
        int Id { get; set; }
        int RouteId { get; set; }
        Route Route { get; set; }
        string Name { get; set; }
        DateTime StartStopTime { get; set; }
        int TrainId { get; set; }
        Train Train { get; set; }
    }

    public class TimeTable : ITimeTable
    {
        [Key]
        public int Id { get; set; }
        public int RouteId { get; set; }
        [ForeignKey("RouteId")]
        public Route Route { get; set; }
        public string Name { get; set; }
        public DateTime StartStopTime { get; set; }
        public int TrainId { get; set; }
        public Train Train { get; set; }
    }
}
