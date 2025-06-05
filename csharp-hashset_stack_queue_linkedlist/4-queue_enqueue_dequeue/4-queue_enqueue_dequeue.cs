using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        
        aQueue.Enqueue(newItem);
        
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");
        
        if (containsSearch)
        {
            List<string> allItems = new List<string>(aQueue);
            aQueue.Clear();
            
            int searchIndex = allItems.IndexOf(search);
            
            for (int i = searchIndex + 1; i < allItems.Count; i++)
            {
                aQueue.Enqueue(allItems[i]);
            }
        }
        
        return aQueue;
    }
}