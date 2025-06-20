﻿using System;

public static class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}