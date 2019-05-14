using NameSorter.src.Models;
using System.Collections.Generic;

namespace NameSorter.src.OrderNames
{
    interface IOrderNames
    {
        List<Name> OrderByLastName(List<Name> names);

        List<Name> OrderByGivenNames(List<Name> names);
    }
}
