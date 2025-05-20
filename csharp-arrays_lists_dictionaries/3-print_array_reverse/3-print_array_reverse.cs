using System;

class Array
{
    public static void Reverse(int[] array)
    {
        // Explicitly using System.Array.Reverse which will generate warnings for null values
        System.Array.Reverse(array);
        
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