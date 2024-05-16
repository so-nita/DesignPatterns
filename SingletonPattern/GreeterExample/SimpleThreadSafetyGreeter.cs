using SingletonPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.GreeterExample
{
    public class SimpleThreadSafetyGreeter : BaseGreeter
    {
        public static readonly object Padlock = new object();

        private static SimpleThreadSafetyGreeter? _instance;

        private SimpleThreadSafetyGreeter() { }

        public static SimpleThreadSafetyGreeter? Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleThreadSafetyGreeter();
                    }

                    return _instance;
                }
            }
        }
    }
}
