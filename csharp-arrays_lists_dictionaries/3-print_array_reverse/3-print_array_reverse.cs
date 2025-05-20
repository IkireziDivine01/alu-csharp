using System;

// This attribute ensures parameters are non-null by default in this file
#nullable enable

class Array
{
    // The method expects a non-null array (by default in nullable context)
    public static void Reverse(int[] array)
    {
        // Even though we check for null here, the compiler will still warn
        // because the parameter is declared as non-nullable
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
}