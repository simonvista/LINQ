using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //using LINQ with XML
            //1. data source
            XDocument xml = XDocument.Load("C:/Users/YL/Desktop/Tutorials/C#/LINQ/CodeDoge/LINQTutorial/LINQTutorial/Sample.xml");
            //2. create query
            IEnumerable<string> listOfNames = from item in xml.Descendants("Name")
                                              select (string)item;
            IEnumerable<string> listOfAddressTypes = from item in xml.Descendants("Address")
                                                     select (string)item.Attribute("Type");
            //3. execute query
            foreach (var item in listOfNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");
            foreach (var item in listOfAddressTypes)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();      
        }


    }
}
