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
            var expected = new Name("testFirstName");
            File.AppendAllText(_pathToTestFile, "testFirstName");

            // Assert
            var listOfFileContents = src.ReadFromFile.ReadFromFile.OpenAndReadFileContents(_pathToTestFile);
            var actual = listOfFileContents[0];

            // Act
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.MiddleName, actual.MiddleName);
            Assert.Equal(expected.LastName, actual.LastName);
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
