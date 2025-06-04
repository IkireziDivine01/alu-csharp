using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        
        bool containsSearch = false;
        foreach (string item in aStack)
        {
            if (item == search)
            {
                containsSearch = true;
                break;
            }
        }
        
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");
        
        if (containsSearch)
        {
            string[] allItems = new string[aStack.Count];
            aStack.CopyTo(allItems, 0);
            
            int searchIndex = -1;
            for (int i = 0; i < allItems.Length; i++)
            {
                if (allItems[i] == search)
                {
                    searchIndex = i;
                    break;
                }
            }
            
            aStack.Clear();
            
            for (int i = allItems.Length - 1; i > searchIndex; i--)
            {
                aStack.Push(allItems[i]);
            }
        }
        
        string topItem = aStack.Count > 0 ? aStack.Pop() : null;
        if (topItem != null)
        {
            aStack.Push(topItem);
        }
        
        aStack.Push(newItem);
        
        return aStack;
    }
}