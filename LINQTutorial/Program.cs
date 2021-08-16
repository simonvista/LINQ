using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //using LINQ with Strings
            //1. data source
            string[] countries = { "United States", "China", "Germany", "Iceland", "India" };
            //2. create query
            var containsLetterI = from country in countries
                                  where country.ToLower().Contains('i')
                                  select country;
            var equalsQuery= from country in countries
                             where country.Equals("United States")
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
            Console.ReadKey();      
        }


    }
}
