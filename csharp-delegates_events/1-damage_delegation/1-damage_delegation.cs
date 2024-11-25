using System;

/// <summary>
/// Player class
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

    /// <summary>
    /// Player constructor
    /// </summary>
    /// <param name="name">name of player</param>
    /// <param name="maxHp">maxHp of the player</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Method to print the player health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    delegate void CalculateHealth(float damage);

/// <summary>
/// Method to calculate the damage taken
/// </summary>
/// <param name="damage">damage</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{name} took {damage} damage");
        }
    }

/// <summary>
/// Method to calculate the heal
/// </summary>
/// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"<name> heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
        }
    }
}