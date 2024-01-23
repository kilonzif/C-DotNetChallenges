using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a palindrome!");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Remove spaces and convert to lowercase for case-insensitive comparison
        str = str.Replace(" ", "").ToLower();

        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
