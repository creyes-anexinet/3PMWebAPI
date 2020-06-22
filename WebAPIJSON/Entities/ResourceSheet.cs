using System;
using System.Collections.Generic;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Sheet
    /// </summary>
    public class ResourceSheet
    {
        /// <summary>
        /// Resource Sheet
        /// </summary>
        public ResourceSheet()
        {
            Objects = new List<ResourceObject>();
        }

        /// <summary>
        /// Sheets
        /// </summary>
        public List<ResourceObject> Objects { get; set; }
    }
}
