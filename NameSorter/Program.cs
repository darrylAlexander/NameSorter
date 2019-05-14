using NameSorter.src.Models;
using NameSorter.src.OrderNames;
using NameSorter.src.ReadFromFile;
using System;
using System.Collections.Generic;

namespace NameSorter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the location of the file to read from.");
            var pathToFile = Console.ReadLine();

            List<Name> namesFromFile = ReadFromFile.OpenAndReadFileContents(pathToFile);
            foreach (var name in namesFromFile)
            {
                Console.WriteLine(name.ToString());
            }

            Console.WriteLine();

            List<Name> namesSortedByLastName = new OrderNames().OrderByLastName(namesFromFile);
            foreach (var name in namesSortedByLastName)
            {
                Console.WriteLine(name.ToString());
            }

            Console.ReadLine();
        }
    }
}
