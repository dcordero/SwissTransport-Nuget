using System;

namespace SwissTransport.Models
{
    /// <summary>
    /// Describes a transportation location.
    /// </summary>
    public class Location
    {
        /// The location identifier
        public String Id { get; private set; }

        /// The location name
        public string Name { get; private set; }

        internal Location(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
