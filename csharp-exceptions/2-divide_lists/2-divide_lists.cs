﻿using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int a = list1[i];
                int b = list2[i];
                try
                {
                    result.Add(a / b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                result.Add(0);
            }
        }
        
        return result;
    }
}