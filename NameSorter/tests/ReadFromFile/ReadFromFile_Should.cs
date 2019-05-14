using System;
using System.IO;
using Xunit;

namespace NameSorter.tests.ReadFromFile
{
    public sealed class ReadFromFile_Should : IDisposable
    {
        [Fact(DisplayName = "Return a list of names from line contents of file")]
        public void ReturnListOfLineContents()
        {
            // Arrange
            var expected = "testFirstName";
            File.WriteAllText(_pathToTestFile, expected);

            // Assert
            var systemUnderTest = src.ReadFromFile.ReadFromFile.OpenAndReadFileContents(_pathToTestFile);
            var actual = systemUnderTest[0];

            // Act
            Assert.Equal(expected, actual.GivenName1);
        }

        [Fact(DisplayName = "Return an empty list when file is not found")]
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
