﻿using NameSorter.src.Models;
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
                    var comparisonOrder = x.GivenName1.CompareTo(y.GivenName1);
                    if (comparisonOrder == 0)
                    {
                        comparisonOrder = x.GivenName2.CompareTo(y.GivenName2);
                        if (comparisonOrder == 0)
                        {
                            comparisonOrder = x.GivenName3.CompareTo(y.GivenName3);
                        }
                    }
                    return comparisonOrder;
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
                    var comparisonOrder = x.LastName.CompareTo(y.LastName);
                    if (comparisonOrder == 0)
                    {
                        comparisonOrder = x.GivenName1.CompareTo(y.GivenName1);
                    }
                    return comparisonOrder;
                }
            });
            return names;
        }
    }
}
