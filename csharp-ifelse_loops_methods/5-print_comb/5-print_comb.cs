using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        
        for (int i = 0; i < 100; i++)
        {
            output += i.ToString("D2");
            output += (i == 99) ? "" : ", ";
        }
        
        Console.WriteLine(output);
    }
}