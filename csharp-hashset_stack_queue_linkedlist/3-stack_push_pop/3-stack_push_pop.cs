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
            Stack<string> tempStack = new Stack<string>();
            
            while (aStack.Count > 0)
            {
                string currentItem = aStack.Pop(); 
                if (currentItem == search)
                {
                    break;
                }
            }
            
            aStack.Clear();
            
            Stack<string> reverseTemp = new Stack<string>();
            while (tempStack.Count > 0)
            {
                reverseTemp.Push(tempStack.Pop());
            }
            
            while (reverseTemp.Count > 0)
            {
                aStack.Push(reverseTemp.Pop());
            }
        }
        
        aStack.Push(newItem);
        
        return aStack;
    }
}