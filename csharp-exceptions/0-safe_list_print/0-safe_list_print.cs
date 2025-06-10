using System;
using System.Collections.Generic;

public static class List
{
    public static int SafePrint(List<int> myList, int count)
    {
        int printed = 0;
        
        for (int i = 0; i < count; i++)
        {
            try
            {
                Console.WriteLine(myList[i]);
                printed++;
            }
            catch (ArgumentOutOfRangeException)
            {
                break;
            }
        }
        
        return printed;
    }
}