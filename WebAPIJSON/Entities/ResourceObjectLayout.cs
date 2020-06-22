using System;
using System.Collections.Generic;
using WebAPIJSON.Enums;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Object Layout
    /// </summary>
    public class ResourceObjectLayout : ResourceBase
    {
        /// <summary>
        /// Dimensions
        /// </summary>
        public Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// Mesure
        /// </summary>
        public List<Dictionary<string, string>> Measure { get; set; }
    }
}
