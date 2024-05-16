using SingletonPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.GreeterExample
{
    public class LocklessFullyLazyGreeter : BaseGreeter
    {
        private LocklessFullyLazyGreeter()
        {
        }

        public static LocklessFullyLazyGreeter Instance => Nested.Instance;

        private class Nested
        {
            internal static readonly LocklessFullyLazyGreeter Instance = new LocklessFullyLazyGreeter();

            static Nested()
            {

            }
        }
    }
}
