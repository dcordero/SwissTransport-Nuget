using System;
using SwissTransport.Models;
using SwissTransport.NetworkDTOs;

namespace SwissTransport.Transformers
{
    class StationboardDTOToModel
    {
        internal static Stationboard Transform(StationboardDTO stationboardDTO)
        {
            return new Stationboard(LocationsDTOToModel.Transform(stationboardDTO.Station), 
                                    JourneyDTOToModel.Transform(stationboardDTO.Journeys));
        }
    }
}
