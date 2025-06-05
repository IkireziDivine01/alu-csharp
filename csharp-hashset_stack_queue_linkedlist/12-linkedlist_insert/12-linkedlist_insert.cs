using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0 || n <= myLList.First.Value)
        {
            return myLList.AddFirst(n);
        }
        
        if (n >= myLList.Last.Value)
        {
            return myLList.AddLast(n);
        }
        
        LinkedListNode<int> current = myLList.First;
        while (current.Next != null)
        {
            if (n <= current.Next.Value)
            {
                return myLList.AddBefore(current.Next, n);
            }
            current = current.Next;
        }
        
        return myLList.AddLast(n);
    }
}