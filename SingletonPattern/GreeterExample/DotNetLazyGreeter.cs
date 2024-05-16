using SingletonPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.GreeterExample
{
    public class DotNetLazyGreeter : BaseGreeter
    {
        private static readonly Lazy<DotNetLazyGreeter> _lazy = new(() => new DotNetLazyGreeter());

        private DotNetLazyGreeter() { }

        public static DotNetLazyGreeter Instance => _lazy.Value;
    }
}
