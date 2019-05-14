namespace NameSorter.src.Models
{
    public class Name
    {
        public Name(string givenName1, string lastName = null, string givenName2 = null, string givenName3 = null)
        {
            _givenName1 = givenName1;
            _givenName2 = givenName2;
            _givenName3 = givenName3;
            _lastName = lastName;
        }

        // Methods
        public override string ToString()
        {
            string fullname = GivenName1;

            if (GivenName2 != null)
            {
                fullname += " " + GivenName2;
            }

            if (GivenName3 != null)
            {
                fullname += " " + GivenName3;
            }

            if (LastName != null)
            {
                fullname += " " + LastName;
            }
            return fullname;
        }

        // Properties
        public string GivenName1
        {
            get
            {
                return _givenName1;
            }
        }
        public string GivenName2
        {
            get
            {
                return _givenName2;
            }
        }
        public string GivenName3
        {
            get
            {
                return _givenName3;
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
        private readonly string _givenName1;
        private readonly string _givenName2;
        private readonly string _givenName3;
        private readonly string _lastName;
    }
}
