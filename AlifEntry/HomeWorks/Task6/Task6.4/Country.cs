using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task6.Task6._4
{
    public class Country
    {
        private string _name;
        private string _capital;
        private int _population;
        private string _officialLanguage;

        public Country(string name, string capital, int population, string officialLanguage)
        {
            _name = name;
            _capital = capital;
            _population = population;
            _officialLanguage = officialLanguage;
        }

        public void SetCapital(string capital)
        {
            _capital = capital;
        }

        public string GetCapital()
        {
            return _capital;
        }

        public void SetPopulation(int population)
        {
            _population = population;
        }

        public int GetPopulation()
        {
            return _population;
        }

        public void SetOfficialLanguage(string language)
        {
            _officialLanguage = language;
        }

        public string GetOfficialLanguage()
        {
            return _officialLanguage;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Country Name: {_name}");
            Console.WriteLine($"Capital: {_capital}");
            Console.WriteLine($"Population: {_population:N0}");
            Console.WriteLine($"Official Language: {_officialLanguage}");
        }
    }
}
