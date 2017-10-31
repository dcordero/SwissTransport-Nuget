using System;
using SwissTransport.NetworkDTOs;
using SwissTransport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwissTransport.Transformers
{
   class LocationsDTOToModel
    {
        internal static List<Location> Transform(ListOfLocationsDTO listOfLocationsDTO)
        {
            List<Location> locations = new List<Location>();
            foreach (LocationDTO locationDTO in listOfLocationsDTO.Locations) 
            {
                locations.Add(Transform(locationDTO));
            }
            return locations;
        }

        internal static Location Transform(LocationDTO locationDTO)
        {
            return new Location(locationDTO.Id, locationDTO.Name);
        }
    }
}
