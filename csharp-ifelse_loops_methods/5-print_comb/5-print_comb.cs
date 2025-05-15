// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (c != 'q' && c != 'e')
                output += c;
        }
        
        Console.Write(output);
    }
}