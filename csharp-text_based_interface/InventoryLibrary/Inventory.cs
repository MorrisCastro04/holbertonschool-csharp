using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an item in a user's inventory
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        public string user_id { get; set; }
        /// <summary>
        /// Unique identifier for the item
        /// </summary>
        public string item_id { get; set; }
        /// <summary>
        /// Quantity of the item in the user's inventory
        /// </summary>
        private int _quantity;
        /// <summary>
        /// Quantity of the item in the user's inventory
        /// </summary>
        public int quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Quantity cannot be negative");
                }
                _quantity = value;
            }
        }

        /// <summary>
        /// Creates a new instance of the Inventory class
        /// </summary>
        /// <param name="user_id">user id</param>
        /// <param name="item_id">item id</param>
        /// <param name="quantity">quantity</param>
        /// <exception cref="Exception">item or user cannot be empty</exception>
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            if (string.IsNullOrEmpty(user_id))
            {
                throw new Exception("User ID cannot be empty");
            }
            if (string.IsNullOrEmpty(item_id))
            {
                throw new Exception("Item ID cannot be empty");
            }
            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}