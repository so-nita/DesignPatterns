using StrategyPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortingExample
{
    public class SortByYearOfBirth : ISortStrategy
    {
        public IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons)
        {
            var sortPerson = persons.OrderBy(e=>e.YearOfBirth).ToList();

            return sortPerson;
        }
    }
}
