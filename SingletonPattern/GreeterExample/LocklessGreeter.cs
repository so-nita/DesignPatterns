using SingletonPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.GreeterExample
{
    public class LocklessGreeter : BaseGreeter
    {
        private static readonly LocklessGreeter _instance = new LocklessGreeter();

        static LocklessGreeter() { }

        private LocklessGreeter() { }

        public static LocklessGreeter Instance => _instance;
    }
}
