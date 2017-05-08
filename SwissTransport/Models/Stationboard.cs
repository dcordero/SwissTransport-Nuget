﻿using System;
using System.Collections.Generic;

namespace SwissTransport.Models
{
    /// <summary>
    /// Describes the next connections leaving from a specific location.
    /// </summary>
    public class Stationboard
    {
        /// The first matched location based on the query. The stationboard will be displayed if this is a station.
        public Location Station { get; private set; }

        /// A list of journeys with the stop of the line leaving from that station.
        public List<Journey> Journeys { get; private set; }

        internal Stationboard(Location station, List<Journey> journeys)
        {
            Station = station;
            Journeys = journeys;
        }
    }
}
