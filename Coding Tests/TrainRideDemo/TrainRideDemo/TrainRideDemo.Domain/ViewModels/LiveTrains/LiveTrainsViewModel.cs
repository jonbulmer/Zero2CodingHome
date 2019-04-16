using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainRideDemo.Data;

namespace TrainDemo.Domain
{
    public interface ILiveTrainsViewModel
    {
        int Id { get; set; }
        string Station { get; set; }
        string RouteName { get; set; }
        decimal ArrivalTime  { get; set; }
    }

    public class LiveTrainsViewModel : ILiveTrainsViewModel
    {
        public int Id { get; set; }
        public string Station { get; set; }
        public string RouteName { get; set; }
        public decimal ArrivalTime { get; set; }
    }

   
}

//Select r.Name, spr.ExpectedRelativeArrivalTime, s.Name from routes r
//inner join StopPositionOnRoutes spr on r.Id = spr.RouteId
//inner join StopProximities sp on spr.StopProximityId = sp.Id
//inner join Stops s on sp.StopId = s.Id
//order by PositionIndex