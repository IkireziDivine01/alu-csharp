using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Given sides
        double AB = 64;
        double BC = 121;

        // Calculate AC using Pythagorean Theorem
        double AC = Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2));

        // Format result
        string result = $"The length of AC is: {AC:F2}";

        // Write to a text file
        string filePath = "length_of_AC.txt";
        File.WriteAllText(filePath, result);

        // Optional: Print to console
        Console.WriteLine("Result written to file: " + filePath);
    }
}
