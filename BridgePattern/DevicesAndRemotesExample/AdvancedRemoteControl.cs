using BridgePattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.DevicesAndRemotesExample
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }

        public virtual void Mute()
        {
            Console.WriteLine("Mute smart TV Command is issued through advanced remote.");
            _device.Volume = 0;
        }
    }
}
