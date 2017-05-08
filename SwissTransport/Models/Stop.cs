using System;

namespace SwissTransport.Models
{
    /// <summary>
    /// A checkpoint represents an arrival or a departure point (in time and space) of a connection.
    /// </summary>
    public class Stop
    {
        /// A location object showing this line's stop at the requested station.
        public Location Station { get; private set; }

        /// The arrival time to the checkpoint
        public DateTime? Arrival { get; private set; }

        /// The departure time from the checkpoint
        public DateTime? Departure { get; private set; }

        /// The arrival/departure platform
        public String Platform { get; private set; }

        /// The delay at this checkpoint, can be null if no prognosis is available.
        public int? Delay { get; private set; }

        internal Stop(Location station, DateTime? arrival, DateTime? departure, String platform, int? delay)
        {
            Station = station;
            Arrival = arrival;
            Departure = departure;
            Platform = platform;
            Delay = delay;
        }
    }
}
