using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder output = new StringBuilder();
        bool isFirst = true;
        
        for (int first = 0; first <= 8; first++)
        {
            for (int second = first + 1; second <= 9; second++)
            {
                if (!isFirst)
                {
                    output.Append(", ");
                }
                
                output.Append($"{first}{second}");
                isFirst = false;
            }
        }
        
        Console.WriteLine(output.ToString());
    }
}