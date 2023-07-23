using System;

class Recursion
{
    static void Main()
    {
        string input = "hello world";
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }

    static string ReverseString(string str)
    {
        if (str.Length <= 1)
        {
            return str;
        }
        else
        {
            return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
        }
    }
}
