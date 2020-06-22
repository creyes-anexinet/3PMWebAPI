using System;
using System.Collections.Generic;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Application
    /// </summary>
    public class ResourceApp : ResourceBase
    {
        /// <summary>
        /// Resource Application
        /// </summary>
        public ResourceApp()
        {
            Sheets = new List<ResourceSheet>();
        }

        /// <summary>
        /// Sheets
        /// </summary>
        public List<ResourceSheet> Sheets { get; set; } 
    }
}
