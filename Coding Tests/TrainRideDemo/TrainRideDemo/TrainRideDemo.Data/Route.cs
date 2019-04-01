using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainRideDemo.Data
{
    public class Route
    {
        public Route()
        {
            StopMaxtrixs = new HashSet<StopMaxtrix>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

 
        public ICollection<StopMaxtrix> StopMaxtrixs  { get; set; }
        public ICollection<TimeTable> TimeTables { get; set; }

    }
}
