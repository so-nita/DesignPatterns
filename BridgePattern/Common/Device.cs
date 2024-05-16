using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgePattern.Common
{
    public abstract class Device
    {
        private int _volume;
        private int _channel;

        protected Device()
        {
            Console.WriteLine("Device turning on process started...");

            _volume = 20;
            Channel = 1;
            NumberOfChannels = 100;
            IsTurnedOn = false;
        }

        public int Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                Console.WriteLine($"Device volume is set to: {_volume}");
            }
        }

        public int Channel
        {
            get => _channel;
            set
            {
                _channel = value;
                Console.WriteLine($"Device channel is set to: {_channel}");
            }
        }

        public int NumberOfChannels { get; set; }

        public bool IsTurnedOn { get; set; }

        public virtual void TurnOn() => IsTurnedOn = true;

        public virtual void TurnOff() => IsTurnedOn = false;
    }
}
