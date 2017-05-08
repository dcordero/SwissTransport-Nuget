using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using SwissTransport.Models;
using SwissTransport.NetworkDTOs;
using SwissTransport.Transformers;

namespace SwissTransport
{
    /// <summary>
    /// Public interface to interact with the framework
    /// </summary>
    public class SwissTransportClient
    {
        private ApiClient ApiClient { get; set; }

        /// Public constructor
        public SwissTransportClient()
        {
            ApiClient = new ApiClient();
        }

        /// Returns the matching locations for the given parameters
        public async Task<List<Location>> GetLocations(string locationName)
        {
            var parameters = new Dictionary<string, object> 
            { 
                ["query"] = locationName 
            };

            var listOfLocationsDTO = await ApiClient.HttpGet<ListOfLocationsDTO>("locations", parameters);
            return LocationsDTOToModel.Transform(listOfLocationsDTO);
        }

        /// Returns the next connections leaving from a specific location.
        public async Task<Stationboard> GetStationBoard(string stationName, 
                                                        string stationId = null, 
                                                        List<Transportation> transportations = null,
                                                        DateTime? dateTime = null,
                                                        int? limit = null,
                                                        StationboardType? type = null)
        {
            var parameters = new Dictionary<string, object>
            {
                ["station"] = stationName,
                ["id"] = stationId,
                ["transportations"] = transportations.Select(x => x.GetString()).ToList(),
                ["datetime"] = dateTime?.ToString("yyyy-MM-dd HH:mm"),
                ["limit"] = limit?.ToString(),
                ["type"] = type?.GetString()
            };

            var stationboardDTO = await ApiClient.HttpGet<StationboardDTO>("stationboard", parameters);
            return StationboardDTOToModel.Transform(stationboardDTO);
        }

    }
}
