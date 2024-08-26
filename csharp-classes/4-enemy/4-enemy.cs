using System;


namespace Enemies
{
    /// <summary>
    /// Represents a Zombie class.
    /// </summary>
    public class Zombie
    {
        // health: Represents the health of the zombie
        // name: Represents the zombie name
        private int health;
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Sets the zombie health.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Sets the zombie health.
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        /// <summary>
        /// Returns the value of Health.
        ///</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}