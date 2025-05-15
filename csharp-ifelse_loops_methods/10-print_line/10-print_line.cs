using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
        {
            // If length is 0 or less, only print a new line
            Console.WriteLine();
        }
        else
        {
            // Print the underscore character '_' length times
            for (int i = 0; i < length; i++)
            {
                Console.Write("_");
            }
            // End with a new line
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Line.PrintLine(3);
        Line.PrintLine(0);
        Line.PrintLine(12);
        Line.PrintLine(-98);
    }
}