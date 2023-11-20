using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "Основы программирования в C#";
        string[] words = input.Split(' ');

        Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));

        string result = string.Join(" ", words.Select(word => new string(word.Reverse().ToArray())));

        Console.WriteLine(result);
    }
}
