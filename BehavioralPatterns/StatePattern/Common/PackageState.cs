using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Common
{
    public abstract class PackageState
    {
        public abstract void Proceed(Package package);
        public abstract void Revert(Package package);
        public abstract void PrintStatus();
    }
}
