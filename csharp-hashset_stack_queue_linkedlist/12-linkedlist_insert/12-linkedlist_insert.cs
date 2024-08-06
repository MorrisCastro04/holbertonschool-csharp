using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;

        foreach (int num in myLList)
        {
            if (num <= n && current.Next != null && current.Next.Value >= n)
            {
                return myLList.AddAfter(current, n);
            }
            current = current.Next;
        }
        return myLList.AddLast(n);
    }
}