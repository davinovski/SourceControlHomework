using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlHomework
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public double Population { get; set; }

        public Country(string name, string continent, double population)
        {
            Name = name;
            Continent = continent;
            Population = population;
        }

        public void printCountryAndContinent()
        {
            Console.WriteLine(this.Name + " is located in the continent of " + this.Continent + " and has a population of " + this.Population + " million people.");
        }
        public void printCountryAndContinentReversedOrder()
        {
            Console.WriteLine("One of the countries located in the continent of " + this.Continent + " is " + this.Name);
        }
    }
}
