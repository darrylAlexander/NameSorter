using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.src.ReadFromFile
{
    public class ReadFromFile
    {
        public ReadFromFile(string pathToFile)
        {
            _pathToFile = pathToFile;
        }

        public List<string> OpenAndReadFileContents()
        {
            var listOfLineContents = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(_pathToFile))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listOfLineContents.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                listOfLineContents.Add("The file could not be read: " + e.Message);
            }

            return listOfLineContents;
        }

        // Properties
        public string PathToFile { get; set; }

        // Fields
        private readonly string _pathToFile;
    }
}
