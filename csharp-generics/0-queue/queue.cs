using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    /// <summary>
    /// return the type of the queue
    /// </summary>
    /// <returns>Type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}