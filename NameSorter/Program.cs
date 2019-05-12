using NameSorter.src.ReadFromFile;
using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the location of the file to read from.");
            var pathToFile = Console.ReadLine();
            var fileReader = new ReadFromFile(pathToFile);
            List<string> linesFromFile = fileReader.OpenAndReadFileContents();
            foreach (var line in linesFromFile)
            {
                Console.WriteLine(line);
                Console.ReadLine();
            }
        }
    }
}
