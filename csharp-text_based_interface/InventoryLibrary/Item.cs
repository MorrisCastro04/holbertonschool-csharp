using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// A description of the item.
        /// </summary>
        public string description { get; set; }
        float _price;

        /// <summary>
        /// The price of the item.
        /// </summary>
        public float price
        {
            get => price;
            set => _price = (float)Math.Round(value, 2); // Round to 2 decimal
        }
        /// <summary>
        /// The tags of the item.
        /// </summary>
        public List<string> tags { get; set; }

        /// <summary>
        /// Creates a new item with the given name.
        /// </summary>
        /// <param name="name">name of the item</param>
        /// <exception cref="ArgumentException">name is required</exception>
        public Item(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required for an item.");

            this.name = name;
            this.tags = new List<string>();
        }
    }
}