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

    /// <summary>
    /// Node class
    /// </summary>
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }
        // node Constructor
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// Add a new node to the queue
    /// </summary>
    /// <param name="value">Value of the node</param>
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

    /// <summary>
    /// Remove the first node in the queue
    /// </summary>
    /// <returns> value </returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = head.value;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        count--;
        return value;
    }

    /// <summary>
    /// Remove the first node in the queue
    /// </summary>
    /// <returns>count</returns>
    public int Count()
    {
        return count;
    }
}