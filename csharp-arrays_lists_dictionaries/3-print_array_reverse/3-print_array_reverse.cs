using System;

class Array
{
    public static void Reverse(int[] array)
    {
        // The null check is still here, but the compiler will warn about possible null reference
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null");
        }
        
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

// Adding this to main_2.cs to produce the warning:
class Program
{
    static void Main()
    {
        int[] array = null;
        Array.Reverse(array); // This will trigger the warning CS8604
    }
}