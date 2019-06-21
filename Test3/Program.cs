using System;
using System.Linq;

public class solution
{

    public static void Main()
    {
        Console.WriteLine("Write your sentence to sort by wordlength: ");
        string names = Console.ReadLine();
        Array.ForEach(names.Split(' ').OrderByDescending(x => x.Length).ToArray(), x => Console.WriteLine(x));

    }
}
