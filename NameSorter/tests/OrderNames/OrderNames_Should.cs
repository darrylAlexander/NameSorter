using NameSorter.src.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace NameSorter.tests.OrderNames
{
    public sealed class OrderNames_Should : IDisposable
    {
        [Fact(DisplayName = "Return a list of names ordered by last name")]
        public void ReturnAListOrderedByLastName()
        {
            // Arrange
            var lastNameBeginningWithB = new Name("Bob", "Bananas");
            var lastNameBeginningWithA = new Name("Alice", "Apple");

            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = _nameSorter.OrderByLastName(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact(DisplayName = "Return a list of names ordered by first given name")]
        public void ReturnAListOrderedByGivenName1()
        {
            // Arrange
            var lastNameBeginningWithB = new Name("Bob", null);
            var lastNameBeginningWithA = new Name("Alice", null);

            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = _nameSorter.OrderByLastName(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact(DisplayName = "Return a list of names ordered by first given name when last name is the same")]
        public void ReturnAListOrderedByGivenName1_WhenLastNameIsTheSame()
        {
            // Arrange
            var lastNameBeginningWithB = new Name("Bob", "Jones");
            var lastNameBeginningWithA = new Name("Alice", "Jones");

            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = _nameSorter.OrderByLastName(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact(DisplayName = "Return a list of names ordered by second given name when first name is the same")]
        public void SortByGivenName2_WhenGivenName1IsTheSame()
        {
            // Arrange
            var lastNameBeginningWithB = new Name("Bob", null, "Bananas");
            var lastNameBeginningWithA = new Name("Bob", null, "Apple");

            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = _nameSorter.OrderByLastName(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact(DisplayName = "Return a list of names ordered by third given name when first and second names are the same")]
        public void SortByGivenName3_WhenGivenName1AndGivenName2AreTheSame()
        {
            // Arrange
            var lastNameBeginningWithB = new Name("Bob", null, "Alice", "Bananas");
            var lastNameBeginningWithA = new Name("Bob", null, "Alice", "Apple");

            names.Add(lastNameBeginningWithB);
            names.Add(lastNameBeginningWithA);

            // Act
            var systemUnderTest = _nameSorter.OrderByLastName(names);
            var actual = systemUnderTest.IndexOf(lastNameBeginningWithA);

            // Assert
            Assert.Equal(0, actual);
        }

        public void Dispose()
        {
            names.Clear();
        }

        private readonly src.OrderNames.OrderNames _nameSorter = new src.OrderNames.OrderNames();
        private List<Name> names = new List<Name>();
    }
}
