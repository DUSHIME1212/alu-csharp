using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList == null || n < 0 || n >= myLList.Count)
            return 0;

        LinkedListNode<int> current = myLList.First;
        if (current == null)
            return 0;

        for (int i = 0; i < n; i++)
        {
            current = current.Next;
            if (current == null)
                return 0;
        }

        return current.Value;
    }
}