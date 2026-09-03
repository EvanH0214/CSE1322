using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Pattern Matcher]");
        Console.Write("Enter original text: ");
        string text = Console.ReadLine();
        Console.Write("Enter pattern to find: ");
        string pattern = Console.ReadLine();
        int position = findString(text, pattern);
        Console.WriteLine();

        if (position == -1)
        {
            Console.WriteLine("Pattern could not be found in text!");
        }
        else
        {
            Console.WriteLine("Pattern found at position " + position);
        }
    }


    public static int lengthOfMatch(string text, string pattern)
    {
        if (pattern.Length == 0 || text.Length == 0)
        {
            return 0;
        }
        if (pattern[pattern.Length - 1].Equals(text[text.Length - 1]))
        {
            return 1 + lengthOfMatch(pattern.Substring(0, pattern.Length - 1), text.Substring(0, text.Length - 1));
        }
        else
        {
            return 0;
        }
    }


    public static int calculateSkip(char firstLetter, string text)
    {
        if (text.Length == 0)
        {
            return 0;
        }
        if (text[text.Length - 1].Equals(firstLetter))
        {
            return 0;
        }
        else
        {
            return 1 + calculateSkip(firstLetter, text.Substring(0, text.Length - 1));
        }
    }


    public static int findString(string text, string pattern)
    {
        if (pattern.Length > text.Length)
        {
            return -1;
        }

        int matchLength = lengthOfMatch(pattern, text.Substring(0, pattern.Length));
        
        if (matchLength == pattern.Length)
        {
            return 0;
        }

        char mismatch = pattern[pattern.Length - matchLength - 1];

        string front = pattern.Substring(0, pattern.Length - matchLength - 1);
        string back = pattern.Substring(pattern.Length - matchLength - 1);

        int skip = calculateSkip(mismatch, back);

        if (skip < back.Length)
        {
            skip = 1 + matchLength;
        }

        else
        {
            skip = calculateSkip(mismatch, front);
        }

        int result = findString(text.Substring(skip), pattern);

        if (result == -1)
        {
            return -1;
        }
        return skip + result;
    }

}
