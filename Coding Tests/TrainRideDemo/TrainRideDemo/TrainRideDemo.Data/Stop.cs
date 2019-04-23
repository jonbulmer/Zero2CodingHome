using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{

    public class Stop
    {
        public Stop()
        {
            StopProximities = new HashSet<StopProximity>();
            StopProcedures = new HashSet<StopProcedure>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        public ICollection<StopProximity> StopProximities { get; set; }
        public ICollection<StopProcedure> StopProcedures { get; set; }
    }
}
