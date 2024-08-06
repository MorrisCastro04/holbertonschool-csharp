using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
            return;

        LinkedListNode<int> current = myLList.First;

        for (int i = 0; i < myLList.Count; i++)
        {
            if (i == index)
            {
                myLList.Remove(current);
            }
            current = current.Next;
        }
    }
}