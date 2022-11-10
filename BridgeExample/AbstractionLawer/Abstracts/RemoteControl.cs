using BridgeExample.ImplementationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.AbstractionLawer.Abstracts
{
    public abstract class RemoteControl
    {
        protected ILEDTV ledTv;
        protected RemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
