using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define 3D vector components
        double x = 7;
        double y = -3;
        double z = -9;

        // Calculate magnitude of the vector
        double magnitude = Math.Sqrt(x * x + y * y + z * z);

        // Format result
        string result = $"The length of the vector v = (7, -3, -9) is: {magnitude:F2}";

        // Write the result to a text file
        string filePath = "2-magnitude_3D";
        File.WriteAllText(filePath, result);

        // Optional: Print to console
        Console.WriteLine("Result written to file: " + filePath);
    }
}
