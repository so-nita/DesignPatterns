using SingletonPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.GreeterExample
{
    public class SimpleGreeter : BaseGreeter
    {
        private static SimpleGreeter? _instance;

        private SimpleGreeter()
        {
            Console.WriteLine("Simple singleton instantiated for the first and only time!");
        }

        public static SimpleGreeter? Instance
        {
            get
            {
                Console.WriteLine("Simple singleton being requested...");
                if(_instance == null)
                {
                    _instance = new SimpleGreeter();
                }

                Console.WriteLine("Simple singleton returned");
                return _instance;
            }
        }
    }
}
