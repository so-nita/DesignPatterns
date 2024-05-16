using StrategyPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortingExample
{
    public class SortByFirstName : ISortStrategy
    {
        public IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons)
        {
            var sortPerson = persons.OrderBy(x => x.FirstName).ToList();

            return sortPerson;
        }
    }
}
