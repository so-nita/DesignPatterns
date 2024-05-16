using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Common
{
    public interface IColorPrototype
    {
        IColorPrototype Clone();
    }
}
