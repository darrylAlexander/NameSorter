using NameSorter.src.Models;
using System.Collections.Generic;

namespace NameSorter.src.OrderNames
{
    public class OrderNames: IOrderNames
    {
        public IList<Name> OrderByLastName(List<Name> names)
        {
            names.Sort(delegate (Name x, Name y)
            {
                if (x.LastName == null && y.LastName == null) return 0;
                else if (x.LastName == null) return -1;
                else if (y.LastName == null) return 1;
                else return x.LastName.CompareTo(y.LastName);
            });
            return names;
        }

        public IList<Name> OrderByGivenNames(List<Name> names)
        {
            throw new System.NotImplementedException();
        }
    }
}
