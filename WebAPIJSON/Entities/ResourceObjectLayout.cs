using System;
using System.Collections.Generic;
using WebAPIJSON.Enums;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Object Layout
    /// </summary>
    public class ResourceObjectLayout
    {
        /// <summary>
        /// Dimension Groups
        /// </summary>
        public Dictionary<string, string> DimensionGroups { get; set; }

        /// <summary>
        /// Dimensions
        /// </summary>
        public List<ResourceDimension> Dimensions { get; set; }

        /// <summary>
        /// Mesure
        /// </summary>
        public List<Dictionary<string, string>> Measure { get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        public string TopperValue { get; set; }

        /// <summary>
        /// Help Tips
        /// </summary>
        public Dictionary<string, string> HelpTips { get; set; }
    }
}
