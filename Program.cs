using System.Collections.Generic;
using System;

namespace Comparer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // initialize
            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "abcd"));
            persons.Add(new Person(2, "abcD"));
            persons.Add(new Person(3, "abCd"));
            persons.Add(new Person(4, "aBcd"));
            persons.Add(new Person(5, "Abcd"));

            // Sort and then Order
            Helper helper = new Helper();
            helper.SortPersonList(persons);
            var sortedAndOrdered = helper.OrderPersons(persons);

            //print
            Console.WriteLine("\n");
            Console.WriteLine("Unsorted");
            helper.PrintPersonList(persons);

            Console.WriteLine("Sorting Lexicographically");
            helper.PrintPersonList(sortedAndOrdered);

            // initialize
            List<Person> personsLength = new List<Person>();
            personsLength.Add(new Person(1, "long"));
            personsLength.Add(new Person(2, "longer"));
            personsLength.Add(new Person(3, "longest"));
            personsLength.Add(new Person(4, "longerThanLongest"));
            personsLength.Add(new Person(5, "longestIsLongerThanLonger"));

            //Sort and Order
            helper.SortPersonList(personsLength);
            var sortByLengths = helper.OrderPersonsByLength(personsLength);
            Console.WriteLine("Persons by length");
            helper.PrintPersonList(sortByLengths);
            Console.ReadKey();
        }

    }
}
