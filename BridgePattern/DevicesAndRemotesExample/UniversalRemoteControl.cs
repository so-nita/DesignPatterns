using BridgePattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.DevicesAndRemotesExample
{
    public class UniversalRemoteControl : RemoteControl
    {
        public UniversalRemoteControl(Device device) : base(device)
        {
        }
    }
}
