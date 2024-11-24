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
    /// Return the value of the first node in the queue
    /// </summary>
    /// <returns>value of the first node</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// Print the queue
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>
    /// Concatenate the nodes in the queue
    /// </summary>
    /// <returns></returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        string result = "";
        Node current = head;
        if (typeof(T) == typeof(string))
        {
            while (current != null)
            {
                result += current.value;
                if (current.next != null)
                {
                    result += " ";
                }
                current = current.next;
            }
            return result;
        }
        else if (typeof(T) == typeof(char))
        {
            while (current != null)
            {
                result += current.value;
                current = current.next;
            }
            return result;
        }
        else
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
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