using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlHomework
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }

        public Country(string name, string continent)
        {
            Name = name;
            Continent = continent;
        }

        public void printCountryAndContinent()
        {
            Console.WriteLine(this.Name + " is located in the continent of " + this.Continent);
        }
        public void printCountryAndContinentReversedOrder()
        {
            Console.WriteLine("One of the countries located in the continent of " + this.Continent + " is " + this.Name);
        }
    }
}
