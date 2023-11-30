using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Bir söz daxil edin: ");
        string input = Console.ReadLine();

        PrintText(input);

        Console.ReadLine(); 
    }

    static void PrintText(string text)
    {
        foreach (char character in text)
        {
            Thread thread = new Thread(() => Console.Write(character));
            thread.Start();
            Thread.Sleep(200);
        }
    }
}









