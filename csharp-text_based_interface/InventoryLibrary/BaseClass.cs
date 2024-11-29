using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class for all classes in the library
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Unique identifier for the class
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Date the class was created
        /// </summary>
        public DateTime date_created { get; set; }
        /// <summary>
        /// Date the class was last updated
        /// </summary>
        public DateTime date_updated { get; set; }

        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.Now;
            date_updated = DateTime.Now;
        }
    }
}