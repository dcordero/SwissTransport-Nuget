﻿using System;
using System.Collections.Generic;
using SwissTransport.Models;
using SwissTransport.NetworkDTOs;

namespace SwissTransport.Transformers
{
    class JourneyDTOToModel
    {
        internal static List<Journey> Transform(List<JourneyDTO> journeysDTO)
        {
            List<Journey> journeys = new List<Journey>();
            foreach (JourneyDTO journeyDTO in journeysDTO)
            {
                journeys.Add(Transform(journeyDTO));
            }
            return journeys;
        }

        private static Journey Transform(JourneyDTO journeyDTO)
        {
            return new Journey(journeyDTO.Name, 
                               journeyDTO.To, 
                               StopDTOToModel.Transform(journeyDTO.Stop),
                               StopDTOToModel.Transform(journeyDTO.PassList));
        }
    }
}
