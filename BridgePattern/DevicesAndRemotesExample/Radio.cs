using BridgePattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.DevicesAndRemotesExample
{
    public class Radio : Device
    {
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine("Radio is turned on.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine("Radio is turned off.");
        }
    }
}
