using System;
using System.IO;
using Xunit;

namespace NameSorter.tests.ReadFromFile
{
    public class ReadFromFile_Should : IDisposable
    {
        [Fact]
        public void ReturnListOfLineContents()
        {
            // Arrange
            var expected = "test name";
            File.AppendAllText(_pathToTestFile, expected);

            // Assert
            var listOfFileContents = src.ReadFromFile.ReadFromFile.OpenAndReadFileContents(_pathToTestFile);
            var actual = listOfFileContents.Contains(expected);

            // Act
            Assert.True(actual);
        }

        [Fact]
        public void ReturnListWithAnErrorMessage_WhenFileDoesNotExist()
        {
            // Arrange
            var expected = "The file could not be read.";

            // Assert
            var listOfFileContents = src.ReadFromFile.ReadFromFile.OpenAndReadFileContents(_pathToTestFile);
            var actual = listOfFileContents.Contains(expected);

            // Act
            Assert.True(actual);
        }

        public void Dispose()
        {
            File.Delete(_pathToTestFile);
        }

        private string _pathToTestFile = Directory.GetCurrentDirectory() + "test.txt";
    }
}
