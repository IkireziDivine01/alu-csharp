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
            string[] items = new string[aStack.Count];
            aStack.CopyTo(items, 0);
            
            int searchIndex = Array.IndexOf(items, search);
            
            aStack.Clear();
            
            for (int i = items.Length - 1; i > searchIndex; i--)
            {
                aStack.Push(items[i]);
            }
            
            if (aStack.Count > 0)
            {
                aStack.Pop();
            }
        }
        
        aStack.Push(newItem);
        
        return aStack;
    }
}