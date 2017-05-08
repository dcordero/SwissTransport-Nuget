﻿using System;
using System.Collections.Generic;

namespace SwissTransport.Models
{
    /// <summary>
    /// The actual transportation of a section, e.g. a bus or a train between two stations.
    /// </summary>
    public class Journey
    {
        /// The name of the transportation
        public String Name { get; set; }

        /// Final destination of the transportation
        public String To { get; set; }

        /// Current Stop of the transportation
        public Stop Stop { get; set; }

        /// Checkpoints the transportation passed on the journey
        public List<Stop> PassList { get; set; }

        internal Journey(String name, String to, Stop stop, List<Stop> passList)
        {
            Name = name;
            To = to;
            Stop = stop;
            PassList = passList;
        }
    }
}
