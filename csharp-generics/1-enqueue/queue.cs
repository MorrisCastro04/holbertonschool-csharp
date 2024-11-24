using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;
    /// <summary>
    /// return the type of the queue
    /// </summary>
    /// <returns>Type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
    public class Node
    {
        T value { get; set; };
        public node next { get; set; };

        // node Constructor
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public void Enqueue(T value)
    {
        Node newNode  = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }
    public int Count()
    {
        return count;
    }
}