using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base
{
    public string name { get; set; }

    /// <summary>
    /// Override ToString method
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}