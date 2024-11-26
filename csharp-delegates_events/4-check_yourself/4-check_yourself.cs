using System;

delegate void CalculateHealth(float damage);

/// <summary>
/// CalculateModifier delegate
/// </summary>
/// <param name="baseValue">Base Value</param>
/// <param name="modifier">modifier</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Modifier enum
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier
    /// </summary>
        Weak,
    /// <summary>
    /// Base modifier
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier
    /// </summary>
    Strong
}

/// <summary>
/// Player class
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }
    string status { get; set; }

    EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp) {
            Console.WriteLine($"{name} is in perfect health!");
        } else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp) {
            Console.WriteLine($"{name} is doing well!");
        } else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2) {
            Console.WriteLine($"{name} isn't doing too great...");
        } else if (e.currentHp > 0 && e.currentHp < maxHp / 4) {
            Console.WriteLine($"{name} needs help!");
        } else {
            Console.WriteLine($"{name} is knocked out!");
        }
    }


    /// <summary>
    /// Method to print the player health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }


    /// <summary>
    /// Applies damage to player.
    /// </summary>
    public void TakeDamage(float damage)
    {

        if (damage >= 0)
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp - damage);
        }
        else
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }

    }

    /// <summary>
    /// Rejuvinates player HP.
    /// </summary>
    public void HealDamage(float heal)
    {

        if (heal >= 0)
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp + heal);
        }
        else
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
    }

/// <summary>
/// Validates the HP of the player
/// </summary>
/// <param name="newHp">the new Hp</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }

        HPCheck(this, new CurrentHPArgs(hp));
    }

/// <summary>
/// Apply modifier to the base value
/// </summary>
/// <param name="baseValue">Base Value</param>
/// <param name="modifier">Modifier</param>
/// <returns>return new value</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else
        {
            return baseValue;
        }
    }
}

class CurrentHPArgs : EventArgs
{
    public float currentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}