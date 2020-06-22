using System;
using System.Collections.Generic;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Stream
    /// </summary>
    public class ResourceStream : ResourceBase
    {
        /// <summary>
        /// Resource Stream
        /// </summary>
        public ResourceStream()
        {
            Applications = new List<ResourceApp>();
        }

        /// <summary>
        /// Applications
        /// </summary>
        public List<ResourceApp> Applications { get; set; }
    }
}
