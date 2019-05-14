using NameSorter.src.Models;
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
            var expected = "testFirstName";
            File.AppendAllText(_pathToTestFile, expected);

            // Assert
            var listOfFileContents = src.ReadFromFile.ReadFromFile.OpenAndReadFileContents(_pathToTestFile);
            var actual = listOfFileContents[0];

            // Act
            Assert.Equal(expected, actual.FirstName);
        }

        [Fact]
        public void ReturnEmptyList_WhenFileDoesNotExist()
        {
            // Arrange
            var expected = 0;

            // Assert
            var listOfFileContents = src.ReadFromFile.ReadFromFile.OpenAndReadFileContents(_pathToTestFile);
            var actual = listOfFileContents.Count;

            // Act
            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
            File.Delete(_pathToTestFile);
        }

        private readonly string _pathToTestFile = @"c:\projects\NameSorter\NameSorter\tests\test.txt";
    }
}
