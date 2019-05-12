using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.src.ReadFromFile
{
    public class ReadFromFile
    {
        public static List<string> OpenAndReadFileContents(string pathToFile)
        {
            var listOfLineContents = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listOfLineContents.Add(line);
                    }
                }
            }
            catch (IOException)
            {
                listOfLineContents.Add("The file could not be read.");
            }

            return listOfLineContents;
        }
    }
}
