﻿using NameSorter.src.Models;
using System.Collections.Generic;
using Xunit;

namespace NameSorter.tests.OrderNames
{
    public class OrderNames_Should
    {
        [Fact(DisplayName = "Return a list of names ordered by last name")]
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

        [Fact(DisplayName = "Return a list of names ordered by first given name")]
        public void ReturnAListOrderedByGivenName1()
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

        [Fact(DisplayName = "Return a list of names ordered by second given name when first name is the same")]
        public void SortByGivenName2_WhenGivenName1IsTheSame()
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

        [Fact(DisplayName = "Return a list of names ordered by third given name when first and second names are the same")]
        public void SortByGivenName3_WhenGivenName1AndGivenName2AreTheSame()
        {
            // Arrange
            var nameSorter = new src.OrderNames.OrderNames();
            var lastNameBeginningWithB = new Name("Bob", null, "Alice", "Bananas");
            var lastNameBeginningWithA = new Name("Bob", null, "Alice", "Apple");

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
