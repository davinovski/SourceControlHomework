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

        public string PrintCityMethod()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" ");
            sb.Append(this.Population);
            sb.Append(" ");
            sb.Append(this.Country);
            return sb.ToString();
        }

    }
}
