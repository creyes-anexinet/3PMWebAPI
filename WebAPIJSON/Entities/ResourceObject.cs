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
        /// Resource Object Layout
        /// </summary>
        public ResourceObjectLayout Layout { get; set; }
    }
}
