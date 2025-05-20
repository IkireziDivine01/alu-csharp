using System;

#nullable enable

class Array
{
    public static void Reverse(int[] array)
    {
        // With nullable reference types enabled, not checking for null
        // will generate the expected warning
        
        if (array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            
            if (i > 0)
                Console.Write(" ");
        }
        
        Console.WriteLine();
    }
}