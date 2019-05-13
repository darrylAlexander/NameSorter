using NameSorter.src.Models;
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
            Console.WriteLine("Please enter the location of the file to read from.");
            var pathToFile = Console.ReadLine();
            IList<Name> namesFromFile = ReadFromFile.OpenAndReadFileContents(pathToFile);
            foreach (var name in namesFromFile)
            {
                Console.WriteLine(name.ToString());
                Console.ReadLine();
            }
        }
    }
}
