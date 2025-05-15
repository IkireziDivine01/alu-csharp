using System;

class Character
{
    public static bool IsLower(char c)
    {
        return c >= 97 && c <= 122;
    }
}

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g'};
        int i;

        for (i = 0; i < letters.Length; i++)
        {
            bool isLowercase = letters[i] >= 'a' && letters[i] <= 'z';
            
            if(isLowercase)
                Console.WriteLine("{0} is lowercase", letters[i]);
            else
                Console.WriteLine("{0} is uppercase", letters[i]);
        }
    }
}