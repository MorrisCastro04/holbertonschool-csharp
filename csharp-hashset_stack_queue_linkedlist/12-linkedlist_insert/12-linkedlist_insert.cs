using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First, last = null;

        if (myLList.First == null)
        {
            return myLList.AddFirst(n);
        }

        while (current != null)
        {
            if (current.Value >= n && last.Value < n)
                return myLList.AddBefore(current, n);
            last = current;
            current = current.Next;
        }
        return myLList.AddLast(n);
    }
}