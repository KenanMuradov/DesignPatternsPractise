using BridgeExample.AbstractionLawer.Abstracts;
using BridgeExample.ImplementationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.AbstractionLawer.Concretes
{
    internal class SamsungRemoteControl : RemoteControl
    {
        public SamsungRemoteControl(ILEDTV ledTv) : base(ledTv)
        {
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}
