using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Common
{
    public interface ISortStrategy
    {
        IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons);
    }
}
