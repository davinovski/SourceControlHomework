using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlHomework
{
    class City
    {
        public string Name { get; set; }
        public double Population { get; set; }
        public string Country { get; set; }

        public City(string name, double population, string country)
        {
            Name = name;
            Population = population;
            Country = country;
        }

        public string printMethod()
        {
            return this.Name + " " + this.Population + " " + this.Country;
        }

    }
}
