using NameSorter.src.Models;
using System.Collections.Generic;

namespace NameSorter.src.OrderNames
{
    public class OrderNames: IOrderNames
    {
        public List<Name> OrderByLastName(List<Name> names)
        {
            names.Sort(delegate (Name x, Name y)
            {
                if (x.LastName == null && y.LastName == null)
                {
                    return 0;
                }
                else if (x.LastName == null)
                {
                    return -1;
                }
                else if (y.LastName == null)
                {
                    return 1;
                }
                else
                {
                    return x.LastName.CompareTo(y.LastName);
                }
            });
            return names;
        }

        public List<Name> OrderByGivenNames(List<Name> names)
        {
            names.Sort(delegate (Name x, Name y)
            {
                if (x.FirstName == null && y.FirstName == null)
                {
                    if (x.MiddleName == null && y.MiddleName == null)
                    {
                        return 0;
                    }
                    else if (x.MiddleName == null)
                    {
                        return -1;
                    }
                    else if (y.MiddleName == null)
                    {
                        return 1;
                    }
                    else
                    {
                        return x.MiddleName.CompareTo(y.MiddleName);
                    }
                }
                else if (x.FirstName == null)
                {
                    return -1;
                }
                else if (y.FirstName == null)
                {
                    return 1;
                }
                else
                {
                    var comparisonOrder = x.FirstName.CompareTo(y.FirstName);
                    if ( comparisonOrder == 0)
                    {
                        comparisonOrder = x.MiddleName.CompareTo(y.MiddleName);
                    }

                    return comparisonOrder;
                }
            });
            return names;
        }
    }
}
