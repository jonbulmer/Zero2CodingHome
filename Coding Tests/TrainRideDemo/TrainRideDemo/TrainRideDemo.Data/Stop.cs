using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    interface IStop
    {
        [Key]
        int Id { get; set; }
        [Required]
        string Name { get; set; }
        decimal Longitude { get; set; }
        decimal Latitude { get; set; }

        ICollection<StopProximity> StopProximities { get; set; }
        ICollection<StopProcedure> StopProcedures { get; set; }
    }
    public class Stop : IStop
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
