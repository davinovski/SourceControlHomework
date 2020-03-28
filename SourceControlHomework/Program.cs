using System;

namespace SourceControlHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            City NewYork = new City("New York", 8.6, "USA");
            string NewYorkPrint = NewYork.PrintCityMethod();
            Console.WriteLine(NewYorkPrint);

            Console.ReadKey();
        }
    }
}
