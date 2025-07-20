using System;
using System.IO;

class Program
{
    static void Main()
    {
        double AB = 64;
        double BC = 121;

        // Pythagorean Theorem
        double AC = Math.Sqrt(AB * AB + BC * BC);

        // Round to 2 decimal places
        string result = Math.Round(AC, 2).ToString("F2");

        // Ensure 0-pythagoras is a file, not a directory
        string filePath = "0-pythagoras";
        File.WriteAllText(filePath, result);
    }
}
