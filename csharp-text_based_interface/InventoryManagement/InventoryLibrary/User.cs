using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents a user in the inventory system.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Creates a new user with the given name.
        /// </summary>
        /// <param name="name">user name</param>
        /// <exception cref="ArgumentException">name is required</exception>
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required for a user.");
            this.name = name;
        }
    }
}