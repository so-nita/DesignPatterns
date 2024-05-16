using BridgePattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.DevicesAndRemotesExample
{
    public class SmartTV : Device
    {
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine("Smart TV is turned on.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine("Smart TV is turned off.");
        }
    }
}
