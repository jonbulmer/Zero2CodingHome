using System;
using System.Collections.Generic;
using AbstractFactoryDemo.Interfaces;

namespace AbstractFactoryDemo.Models
{
    class Machine
    {
        public Processor Producer { get; set; }
        public string Model { get; set; }
    }
}
