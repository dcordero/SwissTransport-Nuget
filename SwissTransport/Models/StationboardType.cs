using System;
namespace SwissTransport
{
    /// <summary>
    /// Type of stationboard to filter.
    /// </summary>
    public enum StationboardType
    {
        /// Stationboard for departures
        Departure,
        
        /// Stationboard for arrivals
        Arrival
    };

    static class StationboardTypeMethods
    {
        public static String GetString(this StationboardType transportation)
        {
            switch (transportation)
            {
                case StationboardType.Departure:
                    return "departure";
                case StationboardType.Arrival:
                    return "arrival";
                default:
                    throw new Exception();
            }
        }
    }
}
