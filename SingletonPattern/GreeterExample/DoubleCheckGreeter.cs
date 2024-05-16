using SingletonPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.GreeterExample
{
    public class DoubleCheckGreeter : BaseGreeter
    {
        private static readonly object Padlock = new object();
        private static DoubleCheckGreeter? _instance;

        private DoubleCheckGreeter() { }

        public static DoubleCheckGreeter? Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(Padlock)
                    {
                        if(_instance == null)
                        {
                            _instance = new DoubleCheckGreeter();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
