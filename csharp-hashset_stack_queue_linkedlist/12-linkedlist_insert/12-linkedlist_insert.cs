using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;

        foreach (int num in myLList)
        {
            if (num > n)
            {
                myLList.AddBefore(current, n);
                return current;
            }
            current = current.Next;
        }
        return current;
    }
}