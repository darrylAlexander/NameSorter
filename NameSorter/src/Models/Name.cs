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

        // Methods
        public override string ToString()
        {
            string fullname = FirstName;

            if (MiddleName != "")
            {
                fullname += " " + MiddleName;
            }

            if (LastName != "")
            {
                fullname += " " + LastName;
            }
            return fullname;
        }

        // Properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        // Fields
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _lastName;
    }
}
