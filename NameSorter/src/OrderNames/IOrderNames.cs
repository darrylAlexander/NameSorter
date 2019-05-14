using NameSorter.src.Models;
using System.Collections.Generic;

namespace NameSorter.src.OrderNames
{
    public interface IOrderNames
    {
        List<Name> OrderByLastName(List<Name> names);
    }
}
