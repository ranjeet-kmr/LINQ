using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
               new Person {FirstName="John", LastName="Doe", Age=34},
               new Person {FirstName="Sam", LastName="Mac", Age=14},
               new Person {FirstName="Ram", LastName="moh", Age=24},
               new Person {FirstName="Pam", LastName="Doe", Age=33},
               new Person {FirstName="John", LastName="Mac", Age=44},
            };

            var result = from p in people
                         orderby p.LastName descending
                         group p by p.LastName;
                         //select p;

            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1} ", item.Key, item.Count());

                foreach (var p in item)
                {
                    Console.WriteLine("\t{0} - {1} - {2}", p.FirstName, p.LastName , p.Age);
                }
            }
            Console.Read();
        }
    }

    public class Person
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }

    }
}
