using System;

// Ensure nullable reference types are enabled
#nullable enable

class Array
{
    // Explicitly mark parameter as non-nullable to trigger warning
    public static void Reverse(
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        [System.Diagnostics.CodeAnalysis.DisallowNull] int[] array = null
#pragma warning restore CS8625
    )
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
}