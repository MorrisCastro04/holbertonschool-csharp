using System;


namespace Enemies
{
    /// <summary>
    /// Represents a Zombie class.
    /// </summary>
    public class Zombie
    {
        // Represents the health of the zombie
        private int health;

        /// <summary>
        /// set the zombie health
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// set the zombie health
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
        ///return the value of Health
        ///</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}