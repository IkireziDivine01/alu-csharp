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
            
            while (aStack.Count > 0 && aStack.Peek() != search)
            {
                tempStack.Push(aStack.Peek());
                string[] temp = new string[aStack.Count];
                aStack.CopyTo(temp, 0);
                aStack.Clear();
                for (int i = 1; i < temp.Length; i++)
                {
                    aStack.Push(temp[i]);
                }
            }
            
            if (aStack.Count > 0)
            {
                aStack.Pop();
            }
            
            while (tempStack.Count > 0)
            {
                string[] temp = new string[tempStack.Count];
                tempStack.CopyTo(temp, 0);
                tempStack.Clear();
                for (int i = 1; i < temp.Length; i++)
                {
                    tempStack.Push(temp[i]);
                }
                aStack.Push(temp[0]);
            }
        }
        
        aStack.Push(newItem);
        
        return aStack;
    }
}