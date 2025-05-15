using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        char lastChar = '\0';
        
        // Find the last valid character (not 'q' or 'e') in the range
        for (char c = 'z'; c >= 'a'; c--)
        {
            if (c != 'q' && c != 'e')
            {
                lastChar = c;
                break;
            }
        }
        
        // Build the output string with commas between letters
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (c != 'q' && c != 'e')
            {
                output += c;
                // Add comma only if this is not the last character
                if (c != lastChar)
                {
                    output += ",";
                }
            }
        }
        
        Console.Write(output);
    }
}