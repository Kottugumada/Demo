using System.Collections.Generic;
using System.Linq;
using System;

namespace Comparer
{
    public class Helper
    {
        public void SortPersonList(List<Person> listOfPersons)
        {
            listOfPersons.Sort((s1, s2) => string.Compare(s1.Name, s2.Name));
        }
        public List<Person> OrderPersons(List<Person> listOfPersons)
        {
            return listOfPersons.OrderBy(p => p.Name, new NamesComparer()).ToList();
        }
        public List<Person> OrderPersonsByLength(List<Person> listOfPersons)
        {
            return listOfPersons.OrderBy(p => p.Name.Length, new LengthComparer()).ToList();
        }
        public void PrintPersonList(List<Person> listToBePrinted)
        {
            Console.WriteLine("\n");
            foreach (var person in listToBePrinted)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("\n");
        }
    }

}