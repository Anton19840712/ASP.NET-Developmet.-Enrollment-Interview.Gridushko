using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Write your sentence with duplicate words");
        string str = Console.ReadLine();
         //string[] arr = str.Split(' ');
        string[] arr = str.Split(new Char[] { '.', ',', '!', '?', '-',':', ';', ' ' },
                                 StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(str);
        var a =
        from k in arr
        orderby k
        select k;
        Console.WriteLine("After removing duplicate words...");
        foreach (string res in a.Distinct())
        {
            Console.Write(" " + res.ToLower());
        }
        Console.ReadLine();
    }
}
