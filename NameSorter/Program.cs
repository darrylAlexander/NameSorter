using NameSorter.src.Models;
using NameSorter.src.OrderNames;
using NameSorter.src.ReadFromFile;
using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please add the path of the file to read from as an argument.");
                return;
            }

            List<Name> namesFromFile = ReadFromFile.OpenAndReadFileContents(args[0]);
            List<Name> namesSorted = new OrderNames().OrderByLastName(namesFromFile);

            var filePath = Directory.GetCurrentDirectory() + "\\sorted-names-list.txt";
            var fileContents = "";

            foreach (var name in namesSorted)
            {
                fileContents += name.ToString() + "\r\n";
                Console.WriteLine(name.ToString());
            }

            File.WriteAllText(filePath, fileContents);
        }
    }
}
