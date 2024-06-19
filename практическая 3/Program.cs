using System;

public class Program
{
    public static void Main()
    {
        string input = "Hello, world!";
        int length = GetStringLength(input);
        Console.WriteLine("The length of the string is: " + length);
    }

    public static int GetStringLength(string str)
    {
        return str.Length;
    }
}
