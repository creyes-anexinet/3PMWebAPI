using System;
using System.Collections.Generic;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Data
    /// </summary>
    public class ResourceData
    {
        /// <summary>
        /// Resource Data
        /// </summary>
        public ResourceData()
        {
            Streams = new List<ResourceStream>();
        }

        /// <summary>
        /// Streams
        /// </summary>
        public List<ResourceStream> Streams { get; set; }
    }
}
