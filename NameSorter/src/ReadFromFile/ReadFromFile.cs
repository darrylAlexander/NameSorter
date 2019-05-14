using NameSorter.src.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.src.ReadFromFile
{
    public class ReadFromFile
    {
        public static List<Name> OpenAndReadFileContents(string pathToFile)
        {
            var listOfLineContents = new List<Name>();

            try
            {
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    string line;
                    Name name;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var splitUpNames = line.Split(" ");
                        if (splitUpNames.Length == 1)
                        {
                            name = new Name(splitUpNames[splitUpNames.Length - 1]);
                        }
                        else if (splitUpNames.Length == 2)
                        {
                            name = new Name(splitUpNames[0], splitUpNames[splitUpNames.Length - 1]);
                        }
                        else if (splitUpNames.Length == 3)
                        {
                            name = new Name(splitUpNames[0], splitUpNames[splitUpNames.Length - 1], splitUpNames[1]);
                        }
                        else
                        {
                            name = new Name(splitUpNames[0], splitUpNames[splitUpNames.Length - 1], splitUpNames[1], splitUpNames[2]);
                        }
                        listOfLineContents.Add(name);
                    }
                }
            }
            catch (IOException)
            {
                Console.Error.WriteLine("The file could not be read.");
            }

            return listOfLineContents;
        }
    }
}
