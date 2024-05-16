using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Common
{
    public abstract class RemoteControl
    {
        protected readonly Device _device;
        private readonly int _volumeChangeStep;

        protected RemoteControl(Device device)
        {
            _device = device;   
        }

        public void TogglePower()
        {
            if (_device.IsTurnedOn)
            {
                _device.TurnOff();
                return;
            }
            _device.TurnOn();
        }

        public void VolumnUp()
        {
            var newVolume = _device.Volume + _volumeChangeStep;
            if (newVolume > 100)
            {
                newVolume = 100;
            }

            _device.Volume = newVolume;
        }

        public void VolumnDown()
        {
            var newVolume = _device.Volume + _volumeChangeStep;
            if (newVolume < 0)
            {
                newVolume = 0;
            }

            _device.Volume = newVolume;
        }


        public void ChannelUp()
        {
            var newChannel = _device.Channel + 1;
            if (newChannel > _device.NumberOfChannels)
            {
                newChannel = 1;
            }

            _device.Channel = newChannel;
        }

        public void ChannelDown()
        {
            var newChannel = _device.Channel - 1;
            if(newChannel < 0)
            {
                newChannel = _device.NumberOfChannels;
            }

            _device.Channel = newChannel;
        }
    }
}
