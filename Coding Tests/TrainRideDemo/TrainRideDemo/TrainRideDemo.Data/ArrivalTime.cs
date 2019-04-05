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
        int StopMaxtrixId { get; set; }
        StopMaxtrix StopMaxtrix { get; set; }
    }

    public class ArrivalTime
    {
        public int Id { get; set; }
        public DateTime TimeArrived { get; set; }
        public int StopMaxtrixId { get; set; }
        [ForeignKey("StopMaxtrixId")]
        public StopMaxtrix StopMaxtrix { get; set; }
    }
}
