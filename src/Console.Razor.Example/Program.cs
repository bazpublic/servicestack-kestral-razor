using System;

namespace Console.Razor.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            new ExampleApi().Init().Start("http://*:5001");
            System.Console.WriteLine($"Started at {DateTime.Now}, listening on http://*:5001");
            System.Console.ReadKey();

        }
    }
}
