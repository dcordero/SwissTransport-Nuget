using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwissTransport.NetworkDTOs
{
    [DataContract]
    class StationboardDTO
    {
        [DataMember(Name = "station")]
        internal LocationDTO Station { get; set; }

        [DataMember(Name = "stationboard")]
        internal List<JourneyDTO> Journeys { get; set; }
    }
}
