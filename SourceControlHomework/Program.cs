﻿using System;

namespace SourceControlHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            City NewYork = new City("New York", 8.6, "USA");
            NewYork.PrintCityMethod();
            Console.WriteLine("New York is the biggest city in the United States of America.");
            Country USA = new Country("USA", "North America");
            USA.printCountryAndContinent();
            Console.ReadKey();
        }
    }
}
