using System;
using WebAPIJSON.Enums;

namespace WebAPIJSON.Entities
{
    /// <summary>
    /// Resource Object
    /// </summary>
    public class ResourceObject : ResourceBase
    {
        /// <summary>
        /// Resource Object Properties
        /// </summary>
        public ResourceObjectProperties Properties { get; set; }

        /// <summary>
        /// Resource Object Layout
        /// </summary>
        public ResourceObjectLayout Layout { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public ResourceObjectTypes ObjectType { get; set; }
    }
}
