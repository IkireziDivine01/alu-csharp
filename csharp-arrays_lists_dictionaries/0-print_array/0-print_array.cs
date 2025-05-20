using System;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);
    }
}

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        int[] newArray = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
        }
        
        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(newArray[i]);
                if (i < size - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
        }
        
        return newArray;
    }
}