using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Data
{
    public interface IStopProcedure
    {
        int Id { get; set; }
        Stop Stop { get; set; }
        string Name { get; set; }
        DateTime ActionTime { get; set; }
    }
    public class StopProcedure : IStopProcedure
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public  int StopId { get; set; }
        [ForeignKey("StopId")]
        public Stop Stop { get; set; }

        public string Name { get; set; }

        public DateTime ActionTime { get; set; }
    }
}
