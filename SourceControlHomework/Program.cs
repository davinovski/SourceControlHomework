using System;

namespace SourceControlHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            City NewYork = new City("New York", 8.6, "USA");
             NewYork.PrintCityMethod();

            Console.ReadKey();
        }
    }
}
