using System;

#nullable enable // Enable nullable reference types

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
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
    
    // This method will call Reverse with a null parameter, triggering the warning
    public static void Test()
    {
        int[]? nullArray = null;
        Reverse(nullArray); // This will trigger the warning CS8604
    }
}