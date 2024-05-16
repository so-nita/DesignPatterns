using StrategyPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SortablePersons
    {
        private readonly List<Person> _persons;
        public ISortStrategy SortStrategy { get; set; } = null!;
        public SortablePersons(ISortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
            _persons = new();
        }

        public void Add(Person person) => _persons.Add(person);
        public void Clear() => _persons.Clear();

        public IReadOnlyCollection<Person> Sort()
        {
            var sortedPersons = SortStrategy.Sort(_persons);
            return sortedPersons;
        }
    }
}
