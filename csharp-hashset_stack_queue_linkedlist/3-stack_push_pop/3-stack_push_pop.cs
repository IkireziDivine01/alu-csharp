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
            List<string> itemsToKeep = new List<string>();
            
            string[] stackArray = new string[aStack.Count];
            aStack.CopyTo(stackArray, 0);
            
            bool foundSearch = false;
            for (int i = 0; i < stackArray.Length; i++)
            {
                if (stackArray[i] == search)
                {
                    foundSearch = true;
                    continue;
                }
                if (foundSearch)
                {
                    itemsToKeep.Add(stackArray[i]);
                }
            }
            
            aStack.Clear();
            
            for (int i = itemsToKeep.Count - 1; i >= 0; i--)
            {
                aStack.Push(itemsToKeep[i]);
            }
        }
        
        aStack.Push(newItem);
        
        return aStack;
    }
}