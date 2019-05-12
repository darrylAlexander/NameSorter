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
            List<string> linesFromFile = ReadFromFile.OpenAndReadFileContents(pathToFile);
            foreach (var line in linesFromFile)
            {
                Console.WriteLine(line);
                Console.ReadLine();
            }
        }
    }
}
