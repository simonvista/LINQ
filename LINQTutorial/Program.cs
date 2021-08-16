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
            //1. data source
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //2. create query
            var divBy2Query = from num in nums
                              where num % 2 == 0
                              select num;
            var greaterThan5Query = from num in nums
                                    where num > 5
                                    select num;
            //3. execute query
            foreach (var item in divBy2Query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            foreach (var item in greaterThan5Query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();      
        }


    }
}
