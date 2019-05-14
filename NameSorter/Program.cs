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
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass the path of the file to read from.");
                return;
            }

            List<Name> namesFromFile = ReadFromFile.OpenAndReadFileContents(args[0]);
            List<Name> namesSortedByLastName = new OrderNames().OrderByLastName(namesFromFile);
            foreach (var name in namesSortedByLastName)
            {
                Console.WriteLine(name.ToString());
            }
        }
    }
}
