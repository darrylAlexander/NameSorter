using NameSorter.src.Models;
using System.Collections.Generic;

namespace NameSorter.src.OrderNames
{
    interface IOrderNames
    {
        IList<Name> OrderByLastName(List<Name> names);

        IList<Name> OrderByGivenNames(List<Name> names);
    }
}
