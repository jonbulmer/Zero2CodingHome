using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainDemo.MVC.Models
{
    public interface IStopsDetail
    {
        int StopId { get; set; }
        string Name { get; set; }
        int PositionIndex { get; set; }
    }

    public class StopsDetails : IStopsDetail
    {
        public int StopId { get; set; }
        public string Name { get; set; }
        public int PositionIndex { get; set; }
    }
}