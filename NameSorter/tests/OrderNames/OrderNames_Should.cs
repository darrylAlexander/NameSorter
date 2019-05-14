using NameSorter.src.Models;
using System.Collections.Generic;
using Xunit;

namespace NameSorter.tests.OrderNames
{
    public class OrderNames_Should
    {
        [Fact]
        public void ReturnAListOrderedByLastName()
        {
            // Arrange
            var nameSorter = new src.OrderNames.OrderNames();
            var lastNameBeginningWithB = new Name("Bob", "Bananas");
            var lastNameBeginningWithA = new Name("Alice", "Apple");

            var names = new List<Name>();
            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = nameSorter.OrderByLastName(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void ReturnAListOrderedByGivenNames()
        {
            // Arrange
            var nameSorter = new src.OrderNames.OrderNames();
            var lastNameBeginningWithB = new Name("Bob", "Bananas");
            var lastNameBeginningWithA = new Name("Alice", "Apple");

            var names = new List<Name>();
            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = nameSorter.OrderByGivenNames(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void SortByMiddleName_WhenFirstNameAreSame()
        {
            // Arrange
            var nameSorter = new src.OrderNames.OrderNames();
            var lastNameBeginningWithB = new Name("Bob", null, "Bananas");
            var lastNameBeginningWithA = new Name("Bob", null, "Apple");

            var names = new List<Name>();
            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = nameSorter.OrderByGivenNames(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }
    }
}
