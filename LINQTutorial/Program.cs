using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Program
    {
        static bool GetGermany(string str)
        {
            string Germany = "germany";
            if (str.ToLower().Equals(Germany))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //using functions with LINQ
            //1. data source
            string[] countries = { "United States", "China", "Germany", "Iceland", "India" };
            //2. create query
            var containsLetterI = from country in countries
                                  where country.ToLower().Contains('i')
                                  select country;
            var equalsQuery= from country in countries
                             where country.Equals("United States")
                             select country;
            var equalsMethodQuery = from country in countries
                              where GetGermany(country)
                              select country;
            //3. execute query
            foreach (var item in containsLetterI)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            foreach (var item in equalsQuery)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            foreach (var item in equalsMethodQuery)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();      
        }


    }
}
