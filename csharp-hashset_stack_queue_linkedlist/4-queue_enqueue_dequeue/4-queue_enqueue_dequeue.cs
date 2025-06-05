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
            Queue<string> tempQueue = new Queue<string>();
            bool foundSearch = false;
            
            while (aQueue.Count > 0)
            {
                string currentItem = aQueue.Dequeue();
                
                if (!foundSearch)
                {
                    if (currentItem == search)
                    {
                        foundSearch = true;
                    }
                }
                else
                {
                    tempQueue.Enqueue(currentItem);
                }
            }
            
            while (tempQueue.Count > 0)
            {
                aQueue.Enqueue(tempQueue.Dequeue());
            }
        }
        
        return aQueue;
    }
}