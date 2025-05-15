using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        
        for (int i = 0; i < 100; i++)
        {
            // Format each number with two digits
            output += i.ToString("D2");
            
            // Add comma and space after each number, except the last one
            if (i < 99)
                output += ", ";
        }
        
        // Print all formatted numbers at once and add a new line
        Console.WriteLine(output);
    }
}