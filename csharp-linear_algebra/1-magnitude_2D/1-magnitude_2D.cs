using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define vector components
        double x = 3;
        double y = 9;

        // Calculate magnitude of the vector
        double magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        // Prepare output text
        string result = $"The length of the vector v = (3, 9) is: {magnitude:F2}";

        // Write the result to a text file
        string filePath = "1-magnitude_2D";
        File.WriteAllText(filePath, result);

        // Optional: Output to console
        Console.WriteLine("Result written to file: " + filePath);
    }
}
