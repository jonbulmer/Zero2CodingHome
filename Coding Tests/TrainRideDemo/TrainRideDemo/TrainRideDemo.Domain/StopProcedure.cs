using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainRideDemo.Domain
{
    public class StopProcedure
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
