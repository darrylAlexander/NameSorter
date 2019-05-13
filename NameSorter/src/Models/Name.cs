using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.src.Models
{
    public class Name
    {
        public Name(string firstName, string lastName = "", string middleName = "")
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
        }

        // Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        // Fields
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _lastName;
    }
}
